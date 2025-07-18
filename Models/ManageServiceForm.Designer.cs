using System.Windows.Forms;

namespace Models
{
    partial class ManageServiceForm
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dualButtonPanel1 = new Models.DualButtonPanel();
            this.dualButtonPanel2 = new Models.DualButtonPanel();
            this.logPrinter = new Models.LogPrinter();
            this.mainLayout.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainLayout.Controls.Add(this.leftPanel, 0, 0);
            this.mainLayout.Controls.Add(this.logPrinter, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(10);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(800, 448);
            this.mainLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.dualButtonPanel1, 0, 0);
            this.leftPanel.Controls.Add(this.dualButtonPanel2, 0, 1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(13, 13);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 2;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftPanel.Size = new System.Drawing.Size(150, 422);
            this.leftPanel.TabIndex = 0;
            // 
            // dualButtonPanel1
            // 
            this.dualButtonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dualButtonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dualButtonPanel1.Location = new System.Drawing.Point(3, 3);
            this.dualButtonPanel1.Name = "dualButtonPanel1";
            this.dualButtonPanel1.Size = new System.Drawing.Size(144, 205);
            this.dualButtonPanel1.TabIndex = 0;
            // 
            // dualButtonPanel2
            // 
            this.dualButtonPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dualButtonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dualButtonPanel2.Location = new System.Drawing.Point(3, 214);
            this.dualButtonPanel2.Name = "dualButtonPanel2";
            this.dualButtonPanel2.Size = new System.Drawing.Size(144, 205);
            this.dualButtonPanel2.TabIndex = 1;
            // 
            // logPrinter
            // 
            this.logPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPrinter.Location = new System.Drawing.Point(169, 13);
            this.logPrinter.Name = "logPrinter";
            this.logPrinter.Size = new System.Drawing.Size(618, 422);
            this.logPrinter.TabIndex = 2;
            // 
            // ManageServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.mainLayout);
            this.Name = "ManageServiceForm";
            this.Text = "Service Manager";
            this.mainLayout.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private DualButtonPanel dualButtonPanel1;
        private DualButtonPanel dualButtonPanel2;
        private LogPrinter logPrinter;
    }
}