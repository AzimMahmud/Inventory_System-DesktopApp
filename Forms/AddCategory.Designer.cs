namespace UltimateInventorySystem.Forms
{
    partial class AddCategory
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
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtBoxCategoryName = new System.Windows.Forms.TextBox();
            this.chkAddAsSubCat = new System.Windows.Forms.CheckBox();
            this.comBoxParentCategory = new System.Windows.Forms.ComboBox();
            this.lblParentCategory = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.BackColor = System.Drawing.Color.White;
            this.lblAddCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblAddCategory.Location = new System.Drawing.Point(219, 26);
            this.lblAddCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(157, 25);
            this.lblAddCategory.TabIndex = 0;
            this.lblAddCategory.Text = "Add Category";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(459, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.White;
            this.lblCategoryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblCategoryName.Location = new System.Drawing.Point(24, 94);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(145, 21);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category Name :";
            // 
            // txtBoxCategoryName
            // 
            this.txtBoxCategoryName.Location = new System.Drawing.Point(224, 91);
            this.txtBoxCategoryName.Multiline = true;
            this.txtBoxCategoryName.Name = "txtBoxCategoryName";
            this.txtBoxCategoryName.Size = new System.Drawing.Size(292, 32);
            this.txtBoxCategoryName.TabIndex = 3;
            // 
            // chkAddAsSubCat
            // 
            this.chkAddAsSubCat.AutoSize = true;
            this.chkAddAsSubCat.BackColor = System.Drawing.Color.White;
            this.chkAddAsSubCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.chkAddAsSubCat.Location = new System.Drawing.Point(25, 168);
            this.chkAddAsSubCat.Name = "chkAddAsSubCat";
            this.chkAddAsSubCat.Size = new System.Drawing.Size(199, 25);
            this.chkAddAsSubCat.TabIndex = 4;
            this.chkAddAsSubCat.Text = "Add As Sub Category";
            this.chkAddAsSubCat.UseVisualStyleBackColor = false;
            this.chkAddAsSubCat.CheckedChanged += new System.EventHandler(this.chkAddAsSubCat_CheckedChanged);
            // 
            // comBoxParentCategory
            // 
            this.comBoxParentCategory.FormattingEnabled = true;
            this.comBoxParentCategory.Location = new System.Drawing.Point(224, 229);
            this.comBoxParentCategory.Name = "comBoxParentCategory";
            this.comBoxParentCategory.Size = new System.Drawing.Size(292, 29);
            this.comBoxParentCategory.TabIndex = 5;
            this.comBoxParentCategory.Visible = false;
            // 
            // lblParentCategory
            // 
            this.lblParentCategory.AutoSize = true;
            this.lblParentCategory.BackColor = System.Drawing.Color.White;
            this.lblParentCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblParentCategory.Location = new System.Drawing.Point(23, 232);
            this.lblParentCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParentCategory.Name = "lblParentCategory";
            this.lblParentCategory.Size = new System.Drawing.Size(201, 21);
            this.lblParentCategory.TabIndex = 6;
            this.lblParentCategory.Text = "Select Parent Category :";
            this.lblParentCategory.Visible = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.BackColor = System.Drawing.Color.White;
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.chkIsActive.Location = new System.Drawing.Point(224, 282);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(110, 25);
            this.chkIsActive.TabIndex = 7;
            this.chkIsActive.Text = "Is Active ?";
            this.chkIsActive.UseVisualStyleBackColor = false;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lblParentCategory);
            this.Controls.Add(this.comBoxParentCategory);
            this.Controls.Add(this.chkAddAsSubCat);
            this.Controls.Add(this.txtBoxCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddCategory);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddCategory";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtBoxCategoryName;
        private System.Windows.Forms.CheckBox chkAddAsSubCat;
        private System.Windows.Forms.ComboBox comBoxParentCategory;
        private System.Windows.Forms.Label lblParentCategory;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}