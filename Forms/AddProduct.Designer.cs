namespace UltimateInventorySystem.Forms
{
    partial class AddProduct
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
            this.lblAddNewProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblSubcategoryName = new System.Windows.Forms.Label();
            this.comBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.comBoxSubCategoryName = new System.Windows.Forms.ComboBox();
            this.comBoxUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rTxtBoxDescription = new System.Windows.Forms.RichTextBox();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.btnProdImgBrowse = new System.Windows.Forms.Button();
            this.lblUnitRate = new System.Windows.Forms.Label();
            this.txtBoxUnitRate = new System.Windows.Forms.TextBox();
            this.txtBoxSalesMarginRate = new System.Windows.Forms.TextBox();
            this.lblSalesMarginRate = new System.Windows.Forms.Label();
            this.txtBoxSalesVatRate = new System.Windows.Forms.TextBox();
            this.lblSalesVatRate = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblSubCategoryID = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.lblimagePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewProduct
            // 
            this.lblAddNewProduct.AutoSize = true;
            this.lblAddNewProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblAddNewProduct.Location = new System.Drawing.Point(413, 30);
            this.lblAddNewProduct.Name = "lblAddNewProduct";
            this.lblAddNewProduct.Size = new System.Drawing.Size(192, 25);
            this.lblAddNewProduct.TabIndex = 2;
            this.lblAddNewProduct.Text = "Add New Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(102, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(106, 121);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(260, 27);
            this.txtBoxProductName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblCategoryName.Location = new System.Drawing.Point(424, 97);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(145, 21);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "Category Name :";
            // 
            // lblSubcategoryName
            // 
            this.lblSubcategoryName.AutoSize = true;
            this.lblSubcategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblSubcategoryName.Location = new System.Drawing.Point(688, 97);
            this.lblSubcategoryName.Name = "lblSubcategoryName";
            this.lblSubcategoryName.Size = new System.Drawing.Size(174, 21);
            this.lblSubcategoryName.TabIndex = 5;
            this.lblSubcategoryName.Text = "SubCategory Name :";
            // 
            // comBoxCategoryName
            // 
            this.comBoxCategoryName.FormattingEnabled = true;
            this.comBoxCategoryName.Location = new System.Drawing.Point(429, 121);
            this.comBoxCategoryName.Name = "comBoxCategoryName";
            this.comBoxCategoryName.Size = new System.Drawing.Size(224, 29);
            this.comBoxCategoryName.TabIndex = 2;
            this.comBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comBoxCategoryName_SelectedIndexChanged);
            // 
            // comBoxSubCategoryName
            // 
            this.comBoxSubCategoryName.FormattingEnabled = true;
            this.comBoxSubCategoryName.Location = new System.Drawing.Point(689, 121);
            this.comBoxSubCategoryName.Name = "comBoxSubCategoryName";
            this.comBoxSubCategoryName.Size = new System.Drawing.Size(224, 29);
            this.comBoxSubCategoryName.TabIndex = 3;
            this.comBoxSubCategoryName.SelectedIndexChanged += new System.EventHandler(this.comBoxSubCategoryName_SelectedIndexChanged);
            // 
            // comBoxUnit
            // 
            this.comBoxUnit.FormattingEnabled = true;
            this.comBoxUnit.Location = new System.Drawing.Point(107, 216);
            this.comBoxUnit.Name = "comBoxUnit";
            this.comBoxUnit.Size = new System.Drawing.Size(259, 29);
            this.comBoxUnit.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblUnit.Location = new System.Drawing.Point(105, 191);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(49, 21);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblDescription.Location = new System.Drawing.Point(110, 288);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 21);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description :";
            // 
            // rTxtBoxDescription
            // 
            this.rTxtBoxDescription.Location = new System.Drawing.Point(106, 317);
            this.rTxtBoxDescription.Name = "rTxtBoxDescription";
            this.rTxtBoxDescription.Size = new System.Drawing.Size(547, 65);
            this.rTxtBoxDescription.TabIndex = 7;
            this.rTxtBoxDescription.Text = "";
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblProductImage.Location = new System.Drawing.Point(730, 171);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(136, 21);
            this.lblProductImage.TabIndex = 12;
            this.lblProductImage.Text = "Product Image :";
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBoxProduct.Location = new System.Drawing.Point(734, 204);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(200, 200);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduct.TabIndex = 13;
            this.picBoxProduct.TabStop = false;
            // 
            // btnProdImgBrowse
            // 
            this.btnProdImgBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnProdImgBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdImgBrowse.ForeColor = System.Drawing.Color.White;
            this.btnProdImgBrowse.Location = new System.Drawing.Point(802, 415);
            this.btnProdImgBrowse.Name = "btnProdImgBrowse";
            this.btnProdImgBrowse.Size = new System.Drawing.Size(132, 34);
            this.btnProdImgBrowse.TabIndex = 6;
            this.btnProdImgBrowse.Text = "Browse..";
            this.btnProdImgBrowse.UseVisualStyleBackColor = false;
            this.btnProdImgBrowse.Click += new System.EventHandler(this.btnProdImgBrowse_Click);
            // 
            // lblUnitRate
            // 
            this.lblUnitRate.AutoSize = true;
            this.lblUnitRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblUnitRate.Location = new System.Drawing.Point(428, 194);
            this.lblUnitRate.Name = "lblUnitRate";
            this.lblUnitRate.Size = new System.Drawing.Size(91, 21);
            this.lblUnitRate.TabIndex = 15;
            this.lblUnitRate.Text = "Unit Rate :";
            // 
            // txtBoxUnitRate
            // 
            this.txtBoxUnitRate.Location = new System.Drawing.Point(428, 218);
            this.txtBoxUnitRate.Name = "txtBoxUnitRate";
            this.txtBoxUnitRate.Size = new System.Drawing.Size(225, 27);
            this.txtBoxUnitRate.TabIndex = 5;
            // 
            // txtBoxSalesMarginRate
            // 
            this.txtBoxSalesMarginRate.Location = new System.Drawing.Point(106, 453);
            this.txtBoxSalesMarginRate.Name = "txtBoxSalesMarginRate";
            this.txtBoxSalesMarginRate.Size = new System.Drawing.Size(260, 27);
            this.txtBoxSalesMarginRate.TabIndex = 8;
            // 
            // lblSalesMarginRate
            // 
            this.lblSalesMarginRate.AutoSize = true;
            this.lblSalesMarginRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblSalesMarginRate.Location = new System.Drawing.Point(106, 429);
            this.lblSalesMarginRate.Name = "lblSalesMarginRate";
            this.lblSalesMarginRate.Size = new System.Drawing.Size(177, 21);
            this.lblSalesMarginRate.TabIndex = 17;
            this.lblSalesMarginRate.Text = "Sales Margin Rate (%)";
            // 
            // txtBoxSalesVatRate
            // 
            this.txtBoxSalesVatRate.Location = new System.Drawing.Point(428, 453);
            this.txtBoxSalesVatRate.Name = "txtBoxSalesVatRate";
            this.txtBoxSalesVatRate.Size = new System.Drawing.Size(225, 27);
            this.txtBoxSalesVatRate.TabIndex = 9;
            // 
            // lblSalesVatRate
            // 
            this.lblSalesVatRate.AutoSize = true;
            this.lblSalesVatRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblSalesVatRate.Location = new System.Drawing.Point(428, 428);
            this.lblSalesVatRate.Name = "lblSalesVatRate";
            this.lblSalesVatRate.Size = new System.Drawing.Size(151, 21);
            this.lblSalesVatRate.TabIndex = 19;
            this.lblSalesVatRate.Text = "Sales Vat Rate (%)";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.chkIsActive.Location = new System.Drawing.Point(114, 529);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(110, 25);
            this.chkIsActive.TabIndex = 10;
            this.chkIsActive.Text = "Is Active ?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(724, 604);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(891, 604);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 39);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(106, 63);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(0, 21);
            this.lblProductID.TabIndex = 20;
            this.lblProductID.Visible = false;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(726, 604);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(140, 40);
            this.btnUpdateProduct.TabIndex = 21;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Visible = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblSubCategoryID
            // 
            this.lblSubCategoryID.AutoSize = true;
            this.lblSubCategoryID.Location = new System.Drawing.Point(198, 63);
            this.lblSubCategoryID.Name = "lblSubCategoryID";
            this.lblSubCategoryID.Size = new System.Drawing.Size(0, 21);
            this.lblSubCategoryID.TabIndex = 22;
            this.lblSubCategoryID.Visible = false;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(285, 63);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(0, 21);
            this.lblUnitID.TabIndex = 23;
            this.lblUnitID.Visible = false;
            // 
            // lblimagePath
            // 
            this.lblimagePath.AutoSize = true;
            this.lblimagePath.Location = new System.Drawing.Point(703, 63);
            this.lblimagePath.Name = "lblimagePath";
            this.lblimagePath.Size = new System.Drawing.Size(0, 21);
            this.lblimagePath.TabIndex = 24;
            this.lblimagePath.Visible = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.lblimagePath);
            this.Controls.Add(this.lblUnitID);
            this.Controls.Add(this.lblSubCategoryID);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtBoxSalesVatRate);
            this.Controls.Add(this.lblSalesVatRate);
            this.Controls.Add(this.txtBoxSalesMarginRate);
            this.Controls.Add(this.lblSalesMarginRate);
            this.Controls.Add(this.txtBoxUnitRate);
            this.Controls.Add(this.lblUnitRate);
            this.Controls.Add(this.btnProdImgBrowse);
            this.Controls.Add(this.picBoxProduct);
            this.Controls.Add(this.lblProductImage);
            this.Controls.Add(this.rTxtBoxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.comBoxUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.comBoxSubCategoryName);
            this.Controls.Add(this.comBoxCategoryName);
            this.Controls.Add(this.lblSubcategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblAddNewProduct);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAddNewProduct;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBoxProductName;
        public System.Windows.Forms.Label lblCategoryName;
        public System.Windows.Forms.Label lblSubcategoryName;
        public System.Windows.Forms.ComboBox comBoxCategoryName;
        public System.Windows.Forms.ComboBox comBoxSubCategoryName;
        public System.Windows.Forms.ComboBox comBoxUnit;
        public System.Windows.Forms.Label lblUnit;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.RichTextBox rTxtBoxDescription;
        public System.Windows.Forms.Label lblProductImage;
        public System.Windows.Forms.PictureBox picBoxProduct;
        public System.Windows.Forms.Button btnProdImgBrowse;
        public System.Windows.Forms.Label lblUnitRate;
        public System.Windows.Forms.TextBox txtBoxUnitRate;
        public System.Windows.Forms.TextBox txtBoxSalesMarginRate;
        public System.Windows.Forms.Label lblSalesMarginRate;
        public System.Windows.Forms.TextBox txtBoxSalesVatRate;
        public System.Windows.Forms.Label lblSalesVatRate;
        public System.Windows.Forms.CheckBox chkIsActive;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Label lblProductID;
        public System.Windows.Forms.Button btnUpdateProduct;
        public System.Windows.Forms.Label lblSubCategoryID;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.Label lblimagePath;
    }
}