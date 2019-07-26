namespace UltimateInventorySystem.UserControls
{
    partial class UC_Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportSalesReturn = new System.Windows.Forms.Button();
            this.btnReportPurchaseReturn = new System.Windows.Forms.Button();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.btnReportPurchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReportSalesReturn);
            this.panel1.Controls.Add(this.btnReportPurchaseReturn);
            this.panel1.Controls.Add(this.btnReportSales);
            this.panel1.Controls.Add(this.btnReportPurchase);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 581);
            this.panel1.TabIndex = 0;
            // 
            // btnReportSalesReturn
            // 
            this.btnReportSalesReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReportSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportSalesReturn.ForeColor = System.Drawing.Color.White;
            this.btnReportSalesReturn.Location = new System.Drawing.Point(451, 223);
            this.btnReportSalesReturn.Name = "btnReportSalesReturn";
            this.btnReportSalesReturn.Size = new System.Drawing.Size(297, 71);
            this.btnReportSalesReturn.TabIndex = 4;
            this.btnReportSalesReturn.Text = "Sales Return";
            this.btnReportSalesReturn.UseVisualStyleBackColor = false;
            this.btnReportSalesReturn.Click += new System.EventHandler(this.btnReportSalesReturn_Click);
            // 
            // btnReportPurchaseReturn
            // 
            this.btnReportPurchaseReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReportPurchaseReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPurchaseReturn.ForeColor = System.Drawing.Color.White;
            this.btnReportPurchaseReturn.Location = new System.Drawing.Point(141, 223);
            this.btnReportPurchaseReturn.Name = "btnReportPurchaseReturn";
            this.btnReportPurchaseReturn.Size = new System.Drawing.Size(297, 71);
            this.btnReportPurchaseReturn.TabIndex = 3;
            this.btnReportPurchaseReturn.Text = "Puchase Return";
            this.btnReportPurchaseReturn.UseVisualStyleBackColor = false;
            this.btnReportPurchaseReturn.Click += new System.EventHandler(this.btnReportPurchaseReturn_Click);
            // 
            // btnReportSales
            // 
            this.btnReportSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReportSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportSales.ForeColor = System.Drawing.Color.White;
            this.btnReportSales.Location = new System.Drawing.Point(451, 136);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(297, 71);
            this.btnReportSales.TabIndex = 2;
            this.btnReportSales.Text = "Sales";
            this.btnReportSales.UseVisualStyleBackColor = false;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
            // 
            // btnReportPurchase
            // 
            this.btnReportPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReportPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPurchase.ForeColor = System.Drawing.Color.White;
            this.btnReportPurchase.Location = new System.Drawing.Point(141, 136);
            this.btnReportPurchase.Name = "btnReportPurchase";
            this.btnReportPurchase.Size = new System.Drawing.Size(297, 71);
            this.btnReportPurchase.TabIndex = 1;
            this.btnReportPurchase.Text = "Purchase ";
            this.btnReportPurchase.UseVisualStyleBackColor = false;
            this.btnReportPurchase.Click += new System.EventHandler(this.btnReportPurchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(330, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports Category";
            // 
            // UC_Reports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Reports";
            this.Size = new System.Drawing.Size(883, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReportSalesReturn;
        private System.Windows.Forms.Button btnReportPurchaseReturn;
        private System.Windows.Forms.Button btnReportSales;
        private System.Windows.Forms.Button btnReportPurchase;
        private System.Windows.Forms.Label label1;
    }
}
