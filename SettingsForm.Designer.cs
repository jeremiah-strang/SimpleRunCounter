namespace SimpleRunCounter
{
    partial class SettingsForm
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
            this.lastRunNumCheck = new System.Windows.Forms.CheckBox();
            this.prevRunCountLabel = new System.Windows.Forms.Label();
            this.prevRunCountInput = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prevRunCountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lastRunNumCheck
            // 
            this.lastRunNumCheck.AutoSize = true;
            this.lastRunNumCheck.Location = new System.Drawing.Point(15, 27);
            this.lastRunNumCheck.Name = "lastRunNumCheck";
            this.lastRunNumCheck.Size = new System.Drawing.Size(254, 21);
            this.lastRunNumCheck.TabIndex = 0;
            this.lastRunNumCheck.Text = "Start runs from previous run count?";
            this.lastRunNumCheck.UseVisualStyleBackColor = true;
            // 
            // prevRunCountLabel
            // 
            this.prevRunCountLabel.AutoSize = true;
            this.prevRunCountLabel.Location = new System.Drawing.Point(12, 56);
            this.prevRunCountLabel.Name = "prevRunCountLabel";
            this.prevRunCountLabel.Size = new System.Drawing.Size(134, 17);
            this.prevRunCountLabel.TabIndex = 1;
            this.prevRunCountLabel.Text = "Previous Run Count";
            // 
            // prevRunCountInput
            // 
            this.prevRunCountInput.Location = new System.Drawing.Point(153, 54);
            this.prevRunCountInput.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.prevRunCountInput.Name = "prevRunCountInput";
            this.prevRunCountInput.Size = new System.Drawing.Size(113, 22);
            this.prevRunCountInput.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(401, 252);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 40);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 304);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.prevRunCountInput);
            this.Controls.Add(this.prevRunCountLabel);
            this.Controls.Add(this.lastRunNumCheck);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.prevRunCountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lastRunNumCheck;
        private System.Windows.Forms.Label prevRunCountLabel;
        private System.Windows.Forms.NumericUpDown prevRunCountInput;
        private System.Windows.Forms.Button saveBtn;
    }
}