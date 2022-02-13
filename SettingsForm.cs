using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRunCounter
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            lastRunNumCheck.Checked = Properties.Settings.Default.UseLastRunNumber;
            prevRunCountInput.Value = Properties.Settings.Default.LastRunNumber;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseLastRunNumber = lastRunNumCheck.Checked;
            Properties.Settings.Default.LastRunNumber = (int)prevRunCountInput.Value;
            Properties.Settings.Default.Save();
        }
    }
}
