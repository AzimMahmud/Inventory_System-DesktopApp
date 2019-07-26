namespace UltimateInventorySystem.UserControls
{
    partial class UC_Users
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
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgViewUser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.txtBoxSearchUser = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgViewUser);
            this.tabUsers.Controls.Add(this.panel1);
            this.tabUsers.Controls.Add(this.panel2);
            this.tabUsers.Location = new System.Drawing.Point(4, 30);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(875, 547);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "User List";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgViewUser
            // 
            this.dgViewUser.AllowUserToAddRows = false;
            this.dgViewUser.AllowUserToDeleteRows = false;
            this.dgViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewUser.Location = new System.Drawing.Point(3, 96);
            this.dgViewUser.Name = "dgViewUser";
            this.dgViewUser.ReadOnly = true;
            this.dgViewUser.Size = new System.Drawing.Size(869, 448);
            this.dgViewUser.TabIndex = 1;
            this.dgViewUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewUser_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUserSearch);
            this.panel1.Controls.Add(this.txtBoxSearchUser);
            this.panel1.Controls.Add(this.btnAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(779, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "To Edit / Delete user double click  on user data in the table";
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSearch.ForeColor = System.Drawing.Color.White;
            this.btnUserSearch.Location = new System.Drawing.Point(680, 18);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(93, 39);
            this.btnUserSearch.TabIndex = 3;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // txtBoxSearchUser
            // 
            this.txtBoxSearchUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxSearchUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxSearchUser.Location = new System.Drawing.Point(488, 24);
            this.txtBoxSearchUser.Name = "txtBoxSearchUser";
            this.txtBoxSearchUser.Size = new System.Drawing.Size(186, 27);
            this.txtBoxSearchUser.TabIndex = 2;
            this.txtBoxSearchUser.TextChanged += new System.EventHandler(this.txtBoxSearchUser_TextChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Location = new System.Drawing.Point(18, 14);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(144, 39);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 541);
            this.panel2.TabIndex = 2;
            // 
            // UC_Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(883, 581);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox txtBoxSearchUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgViewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}
