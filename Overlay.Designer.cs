namespace SimpleRunCounter
{
    partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.nextRunBtn = new System.Windows.Forms.Button();
            this.viewDataBtn = new System.Windows.Forms.Button();
            this.lastRunLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.runDescInput = new System.Windows.Forms.TextBox();
            this.runDescLabel = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.currentNotesLabel = new System.Windows.Forms.Label();
            this.currentNotesInput = new System.Windows.Forms.TextBox();
            this.sessionTimeLabel = new System.Windows.Forms.Label();
            this.sessionRunLabel = new System.Windows.Forms.Label();
            this.runNumLabel = new System.Windows.Forms.Label();
            this.overlayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.overlayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nextRunBtn
            // 
            this.nextRunBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nextRunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextRunBtn.Location = new System.Drawing.Point(12, 66);
            this.nextRunBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextRunBtn.Name = "nextRunBtn";
            this.nextRunBtn.Size = new System.Drawing.Size(82, 40);
            this.nextRunBtn.TabIndex = 0;
            this.nextRunBtn.Text = "New Run";
            this.nextRunBtn.UseVisualStyleBackColor = false;
            this.nextRunBtn.Click += new System.EventHandler(this.nextRunBtn_Click);
            // 
            // viewDataBtn
            // 
            this.viewDataBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDataBtn.Location = new System.Drawing.Point(219, 111);
            this.viewDataBtn.Name = "viewDataBtn";
            this.viewDataBtn.Size = new System.Drawing.Size(53, 27);
            this.viewDataBtn.TabIndex = 7;
            this.viewDataBtn.Text = "Data";
            this.viewDataBtn.UseVisualStyleBackColor = false;
            this.viewDataBtn.Click += new System.EventHandler(this.viewDataBtn_Click);
            // 
            // lastRunLabel
            // 
            this.lastRunLabel.AutoSize = true;
            this.lastRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastRunLabel.ForeColor = System.Drawing.Color.White;
            this.lastRunLabel.Location = new System.Drawing.Point(14, 115);
            this.lastRunLabel.Name = "lastRunLabel";
            this.lastRunLabel.Size = new System.Drawing.Size(163, 17);
            this.lastRunLabel.TabIndex = 4;
            this.lastRunLabel.Text = "Click \"New Run\" to begin";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Gray;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(189, 66);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(83, 40);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedLabel.ForeColor = System.Drawing.Color.White;
            this.elapsedLabel.Location = new System.Drawing.Point(166, 33);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elapsedLabel.Size = new System.Drawing.Size(103, 31);
            this.elapsedLabel.TabIndex = 1;
            this.elapsedLabel.Text = "0.0";
            this.elapsedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.Gray;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Location = new System.Drawing.Point(100, 66);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(83, 40);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(248, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 31);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "✕";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // runDescInput
            // 
            this.runDescInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runDescInput.Location = new System.Drawing.Point(12, 173);
            this.runDescInput.Name = "runDescInput";
            this.runDescInput.Size = new System.Drawing.Size(257, 26);
            this.runDescInput.TabIndex = 9;
            // 
            // runDescLabel
            // 
            this.runDescLabel.AutoSize = true;
            this.runDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runDescLabel.ForeColor = System.Drawing.Color.White;
            this.runDescLabel.Location = new System.Drawing.Point(10, 150);
            this.runDescLabel.Name = "runDescLabel";
            this.runDescLabel.Size = new System.Drawing.Size(130, 20);
            this.runDescLabel.TabIndex = 10;
            this.runDescLabel.Text = "Run Description";
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsBtn.Location = new System.Drawing.Point(184, 111);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(31, 27);
            this.settingsBtn.TabIndex = 11;
            this.settingsBtn.Text = "⚙";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // currentNotesLabel
            // 
            this.currentNotesLabel.AutoSize = true;
            this.currentNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNotesLabel.ForeColor = System.Drawing.Color.White;
            this.currentNotesLabel.Location = new System.Drawing.Point(10, 202);
            this.currentNotesLabel.Name = "currentNotesLabel";
            this.currentNotesLabel.Size = new System.Drawing.Size(161, 20);
            this.currentNotesLabel.TabIndex = 13;
            this.currentNotesLabel.Text = "Notes (Current Run)";
            // 
            // currentNotesInput
            // 
            this.currentNotesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNotesInput.Location = new System.Drawing.Point(12, 225);
            this.currentNotesInput.Name = "currentNotesInput";
            this.currentNotesInput.Size = new System.Drawing.Size(257, 26);
            this.currentNotesInput.TabIndex = 12;
            // 
            // sessionTimeLabel
            // 
            this.sessionTimeLabel.ForeColor = System.Drawing.Color.White;
            this.sessionTimeLabel.Location = new System.Drawing.Point(139, 260);
            this.sessionTimeLabel.Name = "sessionTimeLabel";
            this.sessionTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sessionTimeLabel.Size = new System.Drawing.Size(133, 13);
            this.sessionTimeLabel.TabIndex = 14;
            this.sessionTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
            // 
            // sessionRunLabel
            // 
            this.sessionRunLabel.AutoSize = true;
            this.sessionRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionRunLabel.ForeColor = System.Drawing.Color.White;
            this.sessionRunLabel.Location = new System.Drawing.Point(7, 18);
            this.sessionRunLabel.Name = "sessionRunLabel";
            this.sessionRunLabel.Size = new System.Drawing.Size(0, 29);
            this.sessionRunLabel.TabIndex = 15;
            this.sessionRunLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
            // 
            // runNumLabel
            // 
            this.runNumLabel.AutoSize = true;
            this.runNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runNumLabel.ForeColor = System.Drawing.Color.White;
            this.runNumLabel.Location = new System.Drawing.Point(12, 48);
            this.runNumLabel.Name = "runNumLabel";
            this.runNumLabel.Size = new System.Drawing.Size(0, 15);
            this.runNumLabel.TabIndex = 5;
            this.runNumLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // overlayBindingSource
            // 
            this.overlayBindingSource.DataSource = typeof(SimpleRunCounter.Overlay);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.sessionRunLabel);
            this.Controls.Add(this.sessionTimeLabel);
            this.Controls.Add(this.currentNotesLabel);
            this.Controls.Add(this.currentNotesInput);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.runDescLabel);
            this.Controls.Add(this.runDescInput);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.elapsedLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.lastRunLabel);
            this.Controls.Add(this.runNumLabel);
            this.Controls.Add(this.nextRunBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.viewDataBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.overlayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource overlayBindingSource;
        private System.Windows.Forms.Button viewDataBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label lastRunLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox runDescInput;
        private System.Windows.Forms.Label runDescLabel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label currentNotesLabel;
        private System.Windows.Forms.TextBox currentNotesInput;
        private System.Windows.Forms.Label sessionTimeLabel;
        private System.Windows.Forms.Label sessionRunLabel;
        private System.Windows.Forms.Button nextRunBtn;
        private System.Windows.Forms.Label runNumLabel;
    }
}

