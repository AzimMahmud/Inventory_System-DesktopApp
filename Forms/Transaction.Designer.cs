namespace UltimateInventorySystem.Forms
{
    partial class Transaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTransactionHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetTransaction = new System.Windows.Forms.Button();
            this.btnSubmitTransaction = new System.Windows.Forms.Button();
            this.txtBoxNetAmount = new System.Windows.Forms.TextBox();
            this.txtBoxTranType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxVatAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxGrossAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.comBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxProductName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxVat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblTranId = new System.Windows.Forms.Label();
            this.comBoxTranTypeID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTransactionHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 70);
            this.panel1.TabIndex = 1;
            // 
            // lblTransactionHeader
            // 
            this.lblTransactionHeader.AutoSize = true;
            this.lblTransactionHeader.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblTransactionHeader.Location = new System.Drawing.Point(262, 21);
            this.lblTransactionHeader.Name = "lblTransactionHeader";
            this.lblTransactionHeader.Size = new System.Drawing.Size(246, 32);
            this.lblTransactionHeader.TabIndex = 0;
            this.lblTransactionHeader.Text = "Make Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Client Name";
            // 
            // btnResetTransaction
            // 
            this.btnResetTransaction.BackColor = System.Drawing.Color.Black;
            this.btnResetTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTransaction.ForeColor = System.Drawing.Color.White;
            this.btnResetTransaction.Location = new System.Drawing.Point(644, 505);
            this.btnResetTransaction.Name = "btnResetTransaction";
            this.btnResetTransaction.Size = new System.Drawing.Size(128, 44);
            this.btnResetTransaction.TabIndex = 0;
            this.btnResetTransaction.Text = "Reset";
            this.btnResetTransaction.UseVisualStyleBackColor = false;
            // 
            // btnSubmitTransaction
            // 
            this.btnSubmitTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnSubmitTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTransaction.ForeColor = System.Drawing.Color.White;
            this.btnSubmitTransaction.Location = new System.Drawing.Point(510, 505);
            this.btnSubmitTransaction.Name = "btnSubmitTransaction";
            this.btnSubmitTransaction.Size = new System.Drawing.Size(128, 44);
            this.btnSubmitTransaction.TabIndex = 8;
            this.btnSubmitTransaction.Text = "Submit";
            this.btnSubmitTransaction.UseVisualStyleBackColor = false;
            this.btnSubmitTransaction.Click += new System.EventHandler(this.btnSubmitTransaction_Click);
            // 
            // txtBoxNetAmount
            // 
            this.txtBoxNetAmount.Location = new System.Drawing.Point(601, 440);
            this.txtBoxNetAmount.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxNetAmount.Name = "txtBoxNetAmount";
            this.txtBoxNetAmount.ReadOnly = true;
            this.txtBoxNetAmount.Size = new System.Drawing.Size(132, 27);
            this.txtBoxNetAmount.TabIndex = 62;
            this.txtBoxNetAmount.Text = "0";
            // 
            // txtBoxTranType
            // 
            this.txtBoxTranType.Location = new System.Drawing.Point(537, 124);
            this.txtBoxTranType.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxTranType.Multiline = true;
            this.txtBoxTranType.Name = "txtBoxTranType";
            this.txtBoxTranType.ReadOnly = true;
            this.txtBoxTranType.Size = new System.Drawing.Size(200, 29);
            this.txtBoxTranType.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(477, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 61;
            this.label12.Text = "Net Amount";
            // 
            // txtBoxVatAmount
            // 
            this.txtBoxVatAmount.Location = new System.Drawing.Point(179, 437);
            this.txtBoxVatAmount.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxVatAmount.Name = "txtBoxVatAmount";
            this.txtBoxVatAmount.ReadOnly = true;
            this.txtBoxVatAmount.Size = new System.Drawing.Size(132, 27);
            this.txtBoxVatAmount.TabIndex = 60;
            this.txtBoxVatAmount.Text = "0";
            this.txtBoxVatAmount.TextChanged += new System.EventHandler(this.txtBoxVatAmount_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 21);
            this.label11.TabIndex = 59;
            this.label11.Text = "Vat Amount";
            // 
            // txtBoxDiscountAmount
            // 
            this.txtBoxDiscountAmount.Location = new System.Drawing.Point(571, 385);
            this.txtBoxDiscountAmount.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxDiscountAmount.Name = "txtBoxDiscountAmount";
            this.txtBoxDiscountAmount.ReadOnly = true;
            this.txtBoxDiscountAmount.Size = new System.Drawing.Size(162, 27);
            this.txtBoxDiscountAmount.TabIndex = 58;
            this.txtBoxDiscountAmount.Text = "0";
            this.txtBoxDiscountAmount.TextChanged += new System.EventHandler(this.txtBoxDiscountAmount_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 21);
            this.label10.TabIndex = 57;
            this.label10.Text = "Discount Amount";
            // 
            // txtBoxGrossAmount
            // 
            this.txtBoxGrossAmount.Location = new System.Drawing.Point(179, 385);
            this.txtBoxGrossAmount.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxGrossAmount.Name = "txtBoxGrossAmount";
            this.txtBoxGrossAmount.ReadOnly = true;
            this.txtBoxGrossAmount.Size = new System.Drawing.Size(201, 27);
            this.txtBoxGrossAmount.TabIndex = 56;
            this.txtBoxGrossAmount.Text = "0";
            this.txtBoxGrossAmount.TextChanged += new System.EventHandler(this.txtBoxGrossAmount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 55;
            this.label9.Text = "Gross Amount";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(36, 127);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(122, 21);
            this.lblTransaction.TabIndex = 48;
            this.lblTransaction.Text = "Transaction ID";
            this.lblTransaction.Visible = false;
            // 
            // comBoxCustomerName
            // 
            this.comBoxCustomerName.DisplayMember = "CustomerID";
            this.comBoxCustomerName.FormattingEnabled = true;
            this.comBoxCustomerName.Location = new System.Drawing.Point(537, 176);
            this.comBoxCustomerName.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.comBoxCustomerName.Name = "comBoxCustomerName";
            this.comBoxCustomerName.Size = new System.Drawing.Size(200, 29);
            this.comBoxCustomerName.TabIndex = 41;
            this.comBoxCustomerName.ValueMember = "CustomerID";
            this.comBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comBoxCustomerName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 40, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Product Name";
            // 
            // comBoxProductName
            // 
            this.comBoxProductName.DisplayMember = "ProductID";
            this.comBoxProductName.FormattingEnabled = true;
            this.comBoxProductName.Location = new System.Drawing.Point(204, 175);
            this.comBoxProductName.Margin = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.comBoxProductName.Name = "comBoxProductName";
            this.comBoxProductName.Size = new System.Drawing.Size(149, 29);
            this.comBoxProductName.TabIndex = 42;
            this.comBoxProductName.ValueMember = "ProductID";
            this.comBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comBoxProductName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 40, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Date ";
            // 
            // datePickerTransaction
            // 
            this.datePickerTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerTransaction.Location = new System.Drawing.Point(100, 237);
            this.datePickerTransaction.Margin = new System.Windows.Forms.Padding(85, 40, 0, 0);
            this.datePickerTransaction.Name = "datePickerTransaction";
            this.datePickerTransaction.Size = new System.Drawing.Size(200, 27);
            this.datePickerTransaction.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 40, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Rate";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.Location = new System.Drawing.Point(403, 239);
            this.txtBoxRate.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(100, 27);
            this.txtBoxRate.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(30, 40, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantity";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(633, 239);
            this.txtBoxQuantity.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(100, 27);
            this.txtBoxQuantity.TabIndex = 45;
            this.txtBoxQuantity.Text = "0";
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 40, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Discount (%)";
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Location = new System.Drawing.Point(601, 303);
            this.txtBoxDiscount.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.Size = new System.Drawing.Size(128, 27);
            this.txtBoxDiscount.TabIndex = 46;
            this.txtBoxDiscount.Text = "0";
            this.txtBoxDiscount.TextChanged += new System.EventHandler(this.txtBoxDiscount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(30, 40, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 54;
            this.label8.Text = "Vat (%)";
            // 
            // txtBoxVat
            // 
            this.txtBoxVat.Location = new System.Drawing.Point(129, 303);
            this.txtBoxVat.Margin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.txtBoxVat.Name = "txtBoxVat";
            this.txtBoxVat.Size = new System.Drawing.Size(100, 27);
            this.txtBoxVat.TabIndex = 47;
            this.txtBoxVat.TextChanged += new System.EventHandler(this.txtBoxVat_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "Transaction Type";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(178, 127);
            this.lblTransactionID.Margin = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(0, 21);
            this.lblTransactionID.TabIndex = 65;
            this.lblTransactionID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(510, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 44);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(414, 211);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(0, 21);
            this.lblClientID.TabIndex = 67;
            this.lblClientID.Visible = false;
            // 
            // lblTranId
            // 
            this.lblTranId.AutoSize = true;
            this.lblTranId.Location = new System.Drawing.Point(40, 93);
            this.lblTranId.Margin = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.lblTranId.Name = "lblTranId";
            this.lblTranId.Size = new System.Drawing.Size(0, 21);
            this.lblTranId.TabIndex = 68;
            this.lblTranId.Visible = false;
            // 
            // comBoxTranTypeID
            // 
            this.comBoxTranTypeID.DisplayMember = "CustomerID";
            this.comBoxTranTypeID.FormattingEnabled = true;
            this.comBoxTranTypeID.Location = new System.Drawing.Point(178, 124);
            this.comBoxTranTypeID.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.comBoxTranTypeID.Name = "comBoxTranTypeID";
            this.comBoxTranTypeID.Size = new System.Drawing.Size(148, 29);
            this.comBoxTranTypeID.TabIndex = 69;
            this.comBoxTranTypeID.ValueMember = "CustomerID";
            this.comBoxTranTypeID.Visible = false;
            this.comBoxTranTypeID.SelectedIndexChanged += new System.EventHandler(this.comBoxTranTypeID_SelectedIndexChanged);
            // 
            // Transaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.comBoxTranTypeID);
            this.Controls.Add(this.lblTranId);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxNetAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTranType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxVatAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxDiscountAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxGrossAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.comBoxCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoxProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePickerTransaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxVat);
            this.Controls.Add(this.btnResetTransaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmitTransaction);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetTransaction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblTransactionID;
        public System.Windows.Forms.TextBox txtBoxTranType;
        public System.Windows.Forms.Label lblTransaction;
        public System.Windows.Forms.ComboBox comBoxCustomerName;
        public System.Windows.Forms.ComboBox comBoxProductName;
        public System.Windows.Forms.DateTimePicker datePickerTransaction;
        public System.Windows.Forms.TextBox txtBoxRate;
        public System.Windows.Forms.TextBox txtBoxQuantity;
        public System.Windows.Forms.TextBox txtBoxDiscount;
        public System.Windows.Forms.TextBox txtBoxVat;
        public System.Windows.Forms.Label lblClientID;
        public System.Windows.Forms.Label lblTransactionHeader;
        public System.Windows.Forms.TextBox txtBoxNetAmount;
        public System.Windows.Forms.TextBox txtBoxVatAmount;
        public System.Windows.Forms.TextBox txtBoxDiscountAmount;
        public System.Windows.Forms.TextBox txtBoxGrossAmount;
        public System.Windows.Forms.Button btnSubmitTransaction;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblTranId;
        public System.Windows.Forms.ComboBox comBoxTranTypeID;
    }
}