namespace UltimateInventorySystem.UserControls
{
    partial class UC_Purchase
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPurchaseReturn = new System.Windows.Forms.Button();
            this.btnPurchasedItemSearch = new System.Windows.Forms.Button();
            this.txtBoxSearchPurchaseItem = new System.Windows.Forms.TextBox();
            this.btnAddNewPurchase = new System.Windows.Forms.Button();
            this.dgViewPurchases = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnPurchaseReturn);
            this.panel2.Controls.Add(this.btnPurchasedItemSearch);
            this.panel2.Controls.Add(this.txtBoxSearchPurchaseItem);
            this.panel2.Controls.Add(this.btnAddNewPurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 97);
            this.panel2.TabIndex = 2;
            // 
            // btnPurchaseReturn
            // 
            this.btnPurchaseReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnPurchaseReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseReturn.ForeColor = System.Drawing.Color.Transparent;
            this.btnPurchaseReturn.Location = new System.Drawing.Point(204, 14);
            this.btnPurchaseReturn.Name = "btnPurchaseReturn";
            this.btnPurchaseReturn.Size = new System.Drawing.Size(180, 39);
            this.btnPurchaseReturn.TabIndex = 4;
            this.btnPurchaseReturn.Text = "Purchase Return";
            this.btnPurchaseReturn.UseVisualStyleBackColor = false;
            this.btnPurchaseReturn.Click += new System.EventHandler(this.btnPurchaseReturn_Click);
            // 
            // btnPurchasedItemSearch
            // 
            this.btnPurchasedItemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnPurchasedItemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasedItemSearch.ForeColor = System.Drawing.Color.White;
            this.btnPurchasedItemSearch.Location = new System.Drawing.Point(715, 18);
            this.btnPurchasedItemSearch.Name = "btnPurchasedItemSearch";
            this.btnPurchasedItemSearch.Size = new System.Drawing.Size(144, 39);
            this.btnPurchasedItemSearch.TabIndex = 3;
            this.btnPurchasedItemSearch.Text = "Search";
            this.btnPurchasedItemSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearchPurchaseItem
            // 
            this.txtBoxSearchPurchaseItem.Location = new System.Drawing.Point(523, 18);
            this.txtBoxSearchPurchaseItem.Multiline = true;
            this.txtBoxSearchPurchaseItem.Name = "txtBoxSearchPurchaseItem";
            this.txtBoxSearchPurchaseItem.Size = new System.Drawing.Size(186, 39);
            this.txtBoxSearchPurchaseItem.TabIndex = 2;
            // 
            // btnAddNewPurchase
            // 
            this.btnAddNewPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddNewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPurchase.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewPurchase.Location = new System.Drawing.Point(18, 14);
            this.btnAddNewPurchase.Name = "btnAddNewPurchase";
            this.btnAddNewPurchase.Size = new System.Drawing.Size(180, 39);
            this.btnAddNewPurchase.TabIndex = 1;
            this.btnAddNewPurchase.Text = "New Purchase";
            this.btnAddNewPurchase.UseVisualStyleBackColor = false;
            this.btnAddNewPurchase.Click += new System.EventHandler(this.btnAddNewPurchase_Click);
            // 
            // dgViewPurchases
            // 
            this.dgViewPurchases.AllowUserToAddRows = false;
            this.dgViewPurchases.AllowUserToDeleteRows = false;
            this.dgViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewPurchases.Location = new System.Drawing.Point(0, 97);
            this.dgViewPurchases.Name = "dgViewPurchases";
            this.dgViewPurchases.ReadOnly = true;
            this.dgViewPurchases.Size = new System.Drawing.Size(883, 484);
            this.dgViewPurchases.TabIndex = 3;
            this.dgViewPurchases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPurchases_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // UC_Purchase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgViewPurchases);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Purchase";
            this.Size = new System.Drawing.Size(883, 581);
            this.Load += new System.EventHandler(this.UC_Purchase_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPurchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPurchasedItemSearch;
        private System.Windows.Forms.TextBox txtBoxSearchPurchaseItem;
        private System.Windows.Forms.Button btnAddNewPurchase;
        private System.Windows.Forms.Button btnPurchaseReturn;
        private System.Windows.Forms.DataGridView dgViewPurchases;
        private System.Windows.Forms.Label label1;
    }
}
