﻿namespace Models
{
    partial class LogWindow
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
            this.logPrinter1 = new Models.LogPrinter();
            this.SuspendLayout();
            // 
            // logPrinter1
            // 
            this.logPrinter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPrinter1.Location = new System.Drawing.Point(0, 0);
            this.logPrinter1.Name = "logPrinter1";
            this.logPrinter1.Size = new System.Drawing.Size(800, 450);
            this.logPrinter1.TabIndex = 0;
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logPrinter1);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private LogPrinter logPrinter1;
    }
}