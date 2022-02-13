using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SimpleRunCounter
{
    public partial class Overlay : Form
    {

        #region Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Overlay_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownDrag(sender, e);
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownDrag(sender, e);
        }

        private void mouseDownDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private Timer timer;
        private Timer sessionTimer;
        private DateTime timerStarted;
        private DateTime timerPaused;
        private DateTime sessionTimerStarted;
        private DateTime sessionTimerPaused;
        private TimeSpan sessionTime;
        private List<Run> runs;
        BindingSource runsSource;
        private Run currentRun;
        private int lastRunNum;
        private int lastSessionRunNum;

        private SettingsForm settingsForm;
        private RunDataForm runDataForm;

        public Overlay()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timerTick);
            timerStarted = DateTime.Now;

            sessionTimer = new Timer();
            sessionTimer.Interval = 100;
            sessionTimer.Tick += new EventHandler(sessionTimerTick);
            sessionTimerStarted = DateTime.Now;
            sessionTime = new TimeSpan(0);
            lastSessionRunNum = 0;

            runs = new List<Run>();

            var lastRunDesc = Properties.Settings.Default.LastRunDescription;
            runDescInput.Text = lastRunDesc != null ? lastRunDesc : "";

            if (Properties.Settings.Default.UseLastRunNumber)
            {
                lastRunNum = Math.Max(Properties.Settings.Default.LastRunNumber, 0);
            }
            else
            {
                lastRunNum = 0;
            }

            pauseBtn.Enabled = false;
            stopBtn.Enabled = false;

            runsSource = new BindingSource();
            runsSource.DataSource = runs;
            runDataForm = new RunDataForm(runsSource);
            settingsForm = new SettingsForm();
        }
        
        private void timerTick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - timerStarted;
            currentRun.Duration = elapsed;
            elapsedLabel.Text = currentRun.DurationStr;

            if (nextRunBtn != null && !nextRunBtn.Enabled && elapsed.Milliseconds > 750)
            {
                enableNextRunButton();
            }
        }

        private void sessionTimerTick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - sessionTimerStarted;
            sessionTimeLabel.Text = "Session: " + Run.FormatDurationStr(elapsed + sessionTime);
        }

        private void completeRun()
        {
            if (currentRun != null)
            {
                timer.Stop();
                currentRun.Ended = DateTime.Now;
                currentRun.Description = runDescInput.Text;
                currentRun.Notes = currentNotesInput.Text;
                currentNotesInput.Text = "";

                runs.Add(currentRun);
                runsSource.ResetBindings(false);
                var lastRun = runs[runs.Count - 1];
                var min = lastRun.Duration.Minutes;
                var durStr = "";
                if (min > 0)
                {
                    durStr = min + " min " + lastRun.Duration.Seconds + " sec";
                }
                else
                {
                    durStr = lastRun.Duration.Seconds + " sec";
                }
                lastRunLabel.Text = "Last run: " + durStr;
            }

            currentRun = null;
        }

        private void disableNextRunButton()
        {
            nextRunBtn.Enabled = false;
            nextRunBtn.BackColor = Color.Gray;
        }

        private void enableNextRunButton()
        {
            nextRunBtn.Enabled = true;
            nextRunBtn.BackColor = Color.WhiteSmoke;
        }


        private void disablePauseButton()
        {
            pauseBtn.Enabled = false;
            pauseBtn.BackColor = Color.Gray;
        }

        private void enablePauseButton()
        {
            pauseBtn.Text = "Pause";
            pauseBtn.Enabled = true;
            pauseBtn.BackColor = Color.WhiteSmoke;
        }

        private void disableStopButton()
        {
            stopBtn.Enabled = false;
            stopBtn.BackColor = Color.Gray;
        }

        private void enableStopButton()
        {
            stopBtn.Enabled = true;
            stopBtn.BackColor = Color.WhiteSmoke;
        }

        private void nextRunBtn_Click(object sender, EventArgs e)
        {
            nextRunBtn = (Button)sender;
            disableNextRunButton();
            completeRun();

            var now = DateTime.Now;
            ++lastSessionRunNum;
            currentRun = new Run
            {
                RunNumber = (int)Properties.Settings.Default.LastRunNumber + lastSessionRunNum,
                SessionRunNumber = lastSessionRunNum,
                Notes = "",
                Description = "",
                Duration = new TimeSpan(),
                Started = now,
            };

            runNumLabel.Text = "Total " + currentRun.RunNumber;
            sessionRunLabel.Text = "Run " + currentRun.SessionRunNumber;

            timerStarted = now;
            timer.Start();

            if (!sessionTimer.Enabled)
            {
                sessionTimerStarted = DateTime.Now;
                sessionTimer.Start();
            }

            enablePauseButton();
            enableStopButton();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timerPaused = DateTime.Now;
                timer.Stop();
                currentRun.Duration = DateTime.Now - timerStarted;
                pauseBtn.Text = "Resume";
            }
            else
            {
                timerStarted += DateTime.Now - timerPaused;
                timer.Start();
                pauseBtn.Text = "Pause";
            }

            if (sessionTimer.Enabled)
            {
                sessionTimerPaused = DateTime.Now;
                sessionTime = DateTime.Now - sessionTimerStarted + sessionTime;
                sessionTimer.Stop();
                sessionTimerPaused = DateTime.Now;
            }
            else
            {
                sessionTimer.Start();
                sessionTimerStarted = DateTime.Now;
            }

            nextRunBtn.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            disableStopButton();
            disablePauseButton();
            completeRun();
            runNumLabel.Text = (runs.Count > 0 ? runs[runs.Count - 1].RunNumber : 0) + " Total Runs";
            sessionRunLabel.Text = (runs.Count > 0 ? runs[runs.Count - 1].SessionRunNumber : 0) + " Runs";
            elapsedLabel.Text = "0.0";

            if (sessionTimer.Enabled)
            {
                sessionTimerPaused = DateTime.Now;
                sessionTime = DateTime.Now - sessionTimerStarted + sessionTime;
                sessionTimer.Stop();
                sessionTimerPaused = DateTime.Now;
            }
            else
            {
                sessionTimer.Start();
                sessionTimerStarted = DateTime.Now;
            }

            nextRunBtn.Enabled = true;
        }

        private void viewDataBtn_Click(object sender, EventArgs e)
        {
            if (runDataForm.IsDisposed)
            {
                runDataForm = new RunDataForm(runsSource);
            }
            runDataForm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
            }
            settingsForm.ShowDialog();
        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            completeRun();
            Properties.Settings.Default["LastRunDescription"] = runDescInput.Text;
            Properties.Settings.Default["LastRunNumber"] = runs.Count > 0 ?
                runs[runs.Count - 1].SessionRunNumber + (int)Properties.Settings.Default.LastRunNumber : 0;
            Properties.Settings.Default.Save();
        }
    }
}
