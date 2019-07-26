namespace UltimateInventorySystem.UserControls
{
    partial class UC_Contacts
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
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.dgVewCustomers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.txtBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.dgVewSuppliers = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxSupplierSearch = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnSupplierSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVewCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVewSuppliers)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageSuppliers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.dgVewCustomers);
            this.tabPageCustomers.Controls.Add(this.panel1);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 30);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(875, 547);
            this.tabPageCustomers.TabIndex = 0;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // dgVewCustomers
            // 
            this.dgVewCustomers.AllowUserToAddRows = false;
            this.dgVewCustomers.AllowUserToDeleteRows = false;
            this.dgVewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVewCustomers.Location = new System.Drawing.Point(3, 106);
            this.dgVewCustomers.Name = "dgVewCustomers";
            this.dgVewCustomers.ReadOnly = true;
            this.dgVewCustomers.Size = new System.Drawing.Size(869, 438);
            this.dgVewCustomers.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCustomerSearch);
            this.panel1.Controls.Add(this.txtBoxSearchCustomer);
            this.panel1.Controls.Add(this.btnAddNewCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 103);
            this.panel1.TabIndex = 0;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSearch.Location = new System.Drawing.Point(715, 18);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(144, 39);
            this.btnCustomerSearch.TabIndex = 3;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearchCustomer
            // 
            this.txtBoxSearchCustomer.Location = new System.Drawing.Point(523, 18);
            this.txtBoxSearchCustomer.Multiline = true;
            this.txtBoxSearchCustomer.Name = "txtBoxSearchCustomer";
            this.txtBoxSearchCustomer.Size = new System.Drawing.Size(186, 39);
            this.txtBoxSearchCustomer.TabIndex = 2;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(18, 14);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(180, 39);
            this.btnAddNewCustomer.TabIndex = 1;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Controls.Add(this.dgVewSuppliers);
            this.tabPageSuppliers.Controls.Add(this.panel2);
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppliers.Size = new System.Drawing.Size(875, 555);
            this.tabPageSuppliers.TabIndex = 1;
            this.tabPageSuppliers.Text = "Suppliers";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // dgVewSuppliers
            // 
            this.dgVewSuppliers.AllowUserToAddRows = false;
            this.dgVewSuppliers.AllowUserToDeleteRows = false;
            this.dgVewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVewSuppliers.Location = new System.Drawing.Point(3, 75);
            this.dgVewSuppliers.Name = "dgVewSuppliers";
            this.dgVewSuppliers.ReadOnly = true;
            this.dgVewSuppliers.Size = new System.Drawing.Size(869, 477);
            this.dgVewSuppliers.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBoxSupplierSearch);
            this.panel2.Controls.Add(this.btnAddSupplier);
            this.panel2.Controls.Add(this.btnSupplierSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 72);
            this.panel2.TabIndex = 0;
            // 
            // txtBoxSupplierSearch
            // 
            this.txtBoxSupplierSearch.Location = new System.Drawing.Point(523, 18);
            this.txtBoxSupplierSearch.Multiline = true;
            this.txtBoxSupplierSearch.Name = "txtBoxSupplierSearch";
            this.txtBoxSupplierSearch.Size = new System.Drawing.Size(186, 39);
            this.txtBoxSupplierSearch.TabIndex = 3;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Location = new System.Drawing.Point(18, 14);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(174, 39);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Add New Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSupplierSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSearch.ForeColor = System.Drawing.Color.White;
            this.btnSupplierSearch.Location = new System.Drawing.Point(715, 18);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.Size = new System.Drawing.Size(144, 39);
            this.btnSupplierSearch.TabIndex = 2;
            this.btnSupplierSearch.Text = "Search";
            this.btnSupplierSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // UC_Contacts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Contacts";
            this.Size = new System.Drawing.Size(883, 581);
            this.Load += new System.EventHandler(this.UC_Contacts_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVewCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVewSuppliers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.TextBox txtBoxSearchCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.TabPage tabPageSuppliers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnSupplierSearch;
        private System.Windows.Forms.TextBox txtBoxSupplierSearch;
        private System.Windows.Forms.DataGridView dgVewCustomers;
        private System.Windows.Forms.DataGridView dgVewSuppliers;
        private System.Windows.Forms.Label label1;
    }
}
