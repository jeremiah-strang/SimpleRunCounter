﻿namespace SimpleRunCounter
{
    partial class RunDataForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.runDataGrid = new System.Windows.Forms.DataGridView();
            this.copyDataBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.runDataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 527);
            this.panel1.TabIndex = 0;
            // 
            // runDataGrid
            // 
            this.runDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.runDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runDataGrid.Location = new System.Drawing.Point(0, 0);
            this.runDataGrid.Name = "runDataGrid";
            this.runDataGrid.RowHeadersVisible = false;
            this.runDataGrid.RowTemplate.Height = 24;
            this.runDataGrid.Size = new System.Drawing.Size(842, 527);
            this.runDataGrid.TabIndex = 0;
            // 
            // copyDataBtn
            // 
            this.copyDataBtn.Location = new System.Drawing.Point(3, 4);
            this.copyDataBtn.Name = "copyDataBtn";
            this.copyDataBtn.Size = new System.Drawing.Size(102, 23);
            this.copyDataBtn.TabIndex = 1;
            this.copyDataBtn.Text = "Clipboard";
            this.copyDataBtn.UseVisualStyleBackColor = true;
            this.copyDataBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // RunDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 561);
            this.Controls.Add(this.copyDataBtn);
            this.Controls.Add(this.panel1);
            this.Name = "RunDataForm";
            this.Text = "RunDataForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView runDataGrid;
        private System.Windows.Forms.Button copyDataBtn;
    }
}