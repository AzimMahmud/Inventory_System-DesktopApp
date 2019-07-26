namespace UltimateInventorySystem.UserControls
{
    partial class UC_Sales
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
            this.dgVewSales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalesReturn = new System.Windows.Forms.Button();
            this.btnSalesInfoSearch = new System.Windows.Forms.Button();
            this.txtBoxSearchSalesInfo = new System.Windows.Forms.TextBox();
            this.btnAddNewSales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVewSales)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVewSales
            // 
            this.dgVewSales.AllowUserToAddRows = false;
            this.dgVewSales.AllowUserToDeleteRows = false;
            this.dgVewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVewSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVewSales.Location = new System.Drawing.Point(0, 98);
            this.dgVewSales.Name = "dgVewSales";
            this.dgVewSales.ReadOnly = true;
            this.dgVewSales.Size = new System.Drawing.Size(883, 483);
            this.dgVewSales.TabIndex = 3;
            this.dgVewSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVewSales_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSalesReturn);
            this.panel2.Controls.Add(this.btnSalesInfoSearch);
            this.panel2.Controls.Add(this.txtBoxSearchSalesInfo);
            this.panel2.Controls.Add(this.btnAddNewSales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 98);
            this.panel2.TabIndex = 2;
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturn.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalesReturn.Location = new System.Drawing.Point(204, 14);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Size = new System.Drawing.Size(180, 39);
            this.btnSalesReturn.TabIndex = 4;
            this.btnSalesReturn.Text = "Sales Return";
            this.btnSalesReturn.UseVisualStyleBackColor = false;
            this.btnSalesReturn.Click += new System.EventHandler(this.btnSalesReturn_Click);
            // 
            // btnSalesInfoSearch
            // 
            this.btnSalesInfoSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSalesInfoSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesInfoSearch.ForeColor = System.Drawing.Color.White;
            this.btnSalesInfoSearch.Location = new System.Drawing.Point(715, 18);
            this.btnSalesInfoSearch.Name = "btnSalesInfoSearch";
            this.btnSalesInfoSearch.Size = new System.Drawing.Size(144, 39);
            this.btnSalesInfoSearch.TabIndex = 3;
            this.btnSalesInfoSearch.Text = "Search";
            this.btnSalesInfoSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearchSalesInfo
            // 
            this.txtBoxSearchSalesInfo.Location = new System.Drawing.Point(523, 18);
            this.txtBoxSearchSalesInfo.Multiline = true;
            this.txtBoxSearchSalesInfo.Name = "txtBoxSearchSalesInfo";
            this.txtBoxSearchSalesInfo.Size = new System.Drawing.Size(186, 39);
            this.txtBoxSearchSalesInfo.TabIndex = 2;
            // 
            // btnAddNewSales
            // 
            this.btnAddNewSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddNewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSales.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewSales.Location = new System.Drawing.Point(18, 14);
            this.btnAddNewSales.Name = "btnAddNewSales";
            this.btnAddNewSales.Size = new System.Drawing.Size(180, 39);
            this.btnAddNewSales.TabIndex = 1;
            this.btnAddNewSales.Text = "New Sales";
            this.btnAddNewSales.UseVisualStyleBackColor = false;
            this.btnAddNewSales.Click += new System.EventHandler(this.btnAddNewSales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // UC_Sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgVewSales);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(883, 581);
            this.Load += new System.EventHandler(this.UC_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVewSales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgVewSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalesInfoSearch;
        private System.Windows.Forms.TextBox txtBoxSearchSalesInfo;
        private System.Windows.Forms.Button btnAddNewSales;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Label label1;
    }
}
