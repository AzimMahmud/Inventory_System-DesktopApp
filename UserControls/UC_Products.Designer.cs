namespace UltimateInventorySystem.UserControls
{
    partial class UC_Products
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpageProfuct = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgViewProducts = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.txtBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.tabpageCategory = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgViewCategory = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtBoxSearchCategory = new System.Windows.Forms.TextBox();
            this.tabpageUnit = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgViewUnit = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.txtBoxSearchUnit = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabpageProfuct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewProducts)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabpageCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCategory)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabpageUnit.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUnit)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpageProfuct);
            this.tabControl1.Controls.Add(this.tabpageCategory);
            this.tabControl1.Controls.Add(this.tabpageUnit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 581);
            this.tabControl1.TabIndex = 4;
            // 
            // tabpageProfuct
            // 
            this.tabpageProfuct.Controls.Add(this.panel2);
            this.tabpageProfuct.Location = new System.Drawing.Point(4, 30);
            this.tabpageProfuct.Name = "tabpageProfuct";
            this.tabpageProfuct.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageProfuct.Size = new System.Drawing.Size(875, 547);
            this.tabpageProfuct.TabIndex = 0;
            this.tabpageProfuct.Text = "Products";
            this.tabpageProfuct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgViewProducts);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 541);
            this.panel2.TabIndex = 2;
            // 
            // dgViewProducts
            // 
            this.dgViewProducts.AllowUserToAddRows = false;
            this.dgViewProducts.AllowUserToDeleteRows = false;
            this.dgViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewProducts.Location = new System.Drawing.Point(0, 105);
            this.dgViewProducts.Name = "dgViewProducts";
            this.dgViewProducts.ReadOnly = true;
            this.dgViewProducts.Size = new System.Drawing.Size(869, 436);
            this.dgViewProducts.TabIndex = 5;
            this.dgViewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewProducts_CellDoubleClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btnAddNewProduct);
            this.panel7.Controls.Add(this.txtBoxSearchProduct);
            this.panel7.Controls.Add(this.btnProductSearch);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(869, 105);
            this.panel7.TabIndex = 4;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewProduct.Location = new System.Drawing.Point(15, 24);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(180, 39);
            this.btnAddNewProduct.TabIndex = 1;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // txtBoxSearchProduct
            // 
            this.txtBoxSearchProduct.Location = new System.Drawing.Point(422, 24);
            this.txtBoxSearchProduct.Multiline = true;
            this.txtBoxSearchProduct.Name = "txtBoxSearchProduct";
            this.txtBoxSearchProduct.Size = new System.Drawing.Size(267, 39);
            this.txtBoxSearchProduct.TabIndex = 2;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.ForeColor = System.Drawing.Color.White;
            this.btnProductSearch.Location = new System.Drawing.Point(695, 24);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(151, 39);
            this.btnProductSearch.TabIndex = 3;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            // 
            // tabpageCategory
            // 
            this.tabpageCategory.Controls.Add(this.panel3);
            this.tabpageCategory.Location = new System.Drawing.Point(4, 30);
            this.tabpageCategory.Name = "tabpageCategory";
            this.tabpageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCategory.Size = new System.Drawing.Size(875, 547);
            this.tabpageCategory.TabIndex = 1;
            this.tabpageCategory.Text = "Category";
            this.tabpageCategory.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgViewCategory);
            this.panel3.Controls.Add(this.btnAddCategory);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 541);
            this.panel3.TabIndex = 3;
            // 
            // dgViewCategory
            // 
            this.dgViewCategory.AllowUserToAddRows = false;
            this.dgViewCategory.AllowUserToDeleteRows = false;
            this.dgViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewCategory.Location = new System.Drawing.Point(0, 98);
            this.dgViewCategory.Name = "dgViewCategory";
            this.dgViewCategory.ReadOnly = true;
            this.dgViewCategory.Size = new System.Drawing.Size(869, 443);
            this.dgViewCategory.TabIndex = 6;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Location = new System.Drawing.Point(12, 18);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 39);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnSearchCategory);
            this.panel5.Controls.Add(this.txtBoxSearchCategory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(869, 98);
            this.panel5.TabIndex = 5;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCategory.ForeColor = System.Drawing.Color.White;
            this.btnSearchCategory.Location = new System.Drawing.Point(715, 18);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(144, 39);
            this.btnSearchCategory.TabIndex = 3;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearchCategory
            // 
            this.txtBoxSearchCategory.Location = new System.Drawing.Point(410, 18);
            this.txtBoxSearchCategory.Multiline = true;
            this.txtBoxSearchCategory.Name = "txtBoxSearchCategory";
            this.txtBoxSearchCategory.Size = new System.Drawing.Size(290, 39);
            this.txtBoxSearchCategory.TabIndex = 2;
            // 
            // tabpageUnit
            // 
            this.tabpageUnit.Controls.Add(this.panel4);
            this.tabpageUnit.Location = new System.Drawing.Point(4, 30);
            this.tabpageUnit.Name = "tabpageUnit";
            this.tabpageUnit.Size = new System.Drawing.Size(875, 547);
            this.tabpageUnit.TabIndex = 2;
            this.tabpageUnit.Text = "Unit";
            this.tabpageUnit.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgViewUnit);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 547);
            this.panel4.TabIndex = 3;
            // 
            // dgViewUnit
            // 
            this.dgViewUnit.AllowUserToAddRows = false;
            this.dgViewUnit.AllowUserToDeleteRows = false;
            this.dgViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewUnit.Location = new System.Drawing.Point(0, 113);
            this.dgViewUnit.Name = "dgViewUnit";
            this.dgViewUnit.ReadOnly = true;
            this.dgViewUnit.Size = new System.Drawing.Size(875, 434);
            this.dgViewUnit.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnAddUnit);
            this.panel6.Controls.Add(this.txtBoxSearchUnit);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(875, 113);
            this.panel6.TabIndex = 6;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddUnit.Location = new System.Drawing.Point(17, 33);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(123, 36);
            this.btnAddUnit.TabIndex = 5;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click_1);
            // 
            // txtBoxSearchUnit
            // 
            this.txtBoxSearchUnit.Location = new System.Drawing.Point(515, 33);
            this.txtBoxSearchUnit.Multiline = true;
            this.txtBoxSearchUnit.Name = "txtBoxSearchUnit";
            this.txtBoxSearchUnit.Size = new System.Drawing.Size(184, 39);
            this.txtBoxSearchUnit.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(705, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // UC_Products
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Products";
            this.Size = new System.Drawing.Size(883, 581);
            this.Load += new System.EventHandler(this.UC_Products_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpageProfuct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewProducts)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabpageCategory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCategory)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabpageUnit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUnit)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpageProfuct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.TextBox txtBoxSearchProduct;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.TabPage tabpageCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.TextBox txtBoxSearchCategory;
        private System.Windows.Forms.TabPage tabpageUnit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.TextBox txtBoxSearchUnit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgViewProducts;
        private System.Windows.Forms.DataGridView dgViewCategory;
        private System.Windows.Forms.DataGridView dgViewUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
