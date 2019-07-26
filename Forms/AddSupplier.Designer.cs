namespace UltimateInventorySystem.Forms
{
    partial class AddSupplier
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
            this.lblSupplierHeader = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.txtBoxBusinessName = new System.Windows.Forms.TextBox();
            this.txtBoxContactPerson = new System.Windows.Forms.TextBox();
            this.lblContactPersonName = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSupplierHeader
            // 
            this.lblSupplierHeader.AutoSize = true;
            this.lblSupplierHeader.Font = new System.Drawing.Font("Century Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblSupplierHeader.Location = new System.Drawing.Point(425, 19);
            this.lblSupplierHeader.Name = "lblSupplierHeader";
            this.lblSupplierHeader.Size = new System.Drawing.Size(203, 26);
            this.lblSupplierHeader.TabIndex = 0;
            this.lblSupplierHeader.Text = "Add New Supplier";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblBusinessName.Location = new System.Drawing.Point(142, 126);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(152, 22);
            this.lblBusinessName.TabIndex = 1;
            this.lblBusinessName.Text = "Business Name :";
            // 
            // txtBoxBusinessName
            // 
            this.txtBoxBusinessName.Location = new System.Drawing.Point(146, 151);
            this.txtBoxBusinessName.Multiline = true;
            this.txtBoxBusinessName.Name = "txtBoxBusinessName";
            this.txtBoxBusinessName.Size = new System.Drawing.Size(318, 35);
            this.txtBoxBusinessName.TabIndex = 1;
            // 
            // txtBoxContactPerson
            // 
            this.txtBoxContactPerson.Location = new System.Drawing.Point(602, 151);
            this.txtBoxContactPerson.Multiline = true;
            this.txtBoxContactPerson.Name = "txtBoxContactPerson";
            this.txtBoxContactPerson.Size = new System.Drawing.Size(322, 35);
            this.txtBoxContactPerson.TabIndex = 2;
            // 
            // lblContactPersonName
            // 
            this.lblContactPersonName.AutoSize = true;
            this.lblContactPersonName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblContactPersonName.Location = new System.Drawing.Point(598, 127);
            this.lblContactPersonName.Name = "lblContactPersonName";
            this.lblContactPersonName.Size = new System.Drawing.Size(224, 22);
            this.lblContactPersonName.TabIndex = 3;
            this.lblContactPersonName.Text = "Contact Person Name :";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(146, 243);
            this.txtBoxEmail.Multiline = true;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(318, 35);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblEmail.Location = new System.Drawing.Point(142, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 22);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail :";
            // 
            // txtBoxContactNo
            // 
            this.txtBoxContactNo.Location = new System.Drawing.Point(602, 243);
            this.txtBoxContactNo.Multiline = true;
            this.txtBoxContactNo.Name = "txtBoxContactNo";
            this.txtBoxContactNo.Size = new System.Drawing.Size(322, 35);
            this.txtBoxContactNo.TabIndex = 4;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblContactNo.Location = new System.Drawing.Point(598, 218);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(129, 22);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "Contact No :";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(146, 340);
            this.txtBoxCity.Multiline = true;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(220, 35);
            this.txtBoxCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblCity.Location = new System.Drawing.Point(142, 316);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 22);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City :";
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(422, 340);
            this.txtBoxState.Multiline = true;
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(220, 35);
            this.txtBoxState.TabIndex = 6;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblState.Location = new System.Drawing.Point(418, 316);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 22);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State :";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(704, 340);
            this.txtBoxCountry.Multiline = true;
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(220, 35);
            this.txtBoxCountry.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblCountry.Location = new System.Drawing.Point(700, 316);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(95, 22);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "Country :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(706, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(862, 591);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.chkIsActive.Location = new System.Drawing.Point(146, 406);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(124, 26);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "Is Active ?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(146, 71);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(0, 21);
            this.lblSupplierID.TabIndex = 14;
            this.lblSupplierID.Visible = false;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplier.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(706, 591);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateSupplier.TabIndex = 15;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            this.btnUpdateSupplier.Visible = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBoxContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxContactPerson);
            this.Controls.Add(this.lblContactPersonName);
            this.Controls.Add(this.txtBoxBusinessName);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblSupplierHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblContactPersonName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Label lblSupplierID;
        public System.Windows.Forms.Label lblSupplierHeader;
        public System.Windows.Forms.TextBox txtBoxBusinessName;
        public System.Windows.Forms.TextBox txtBoxContactPerson;
        public System.Windows.Forms.TextBox txtBoxEmail;
        public System.Windows.Forms.TextBox txtBoxContactNo;
        public System.Windows.Forms.TextBox txtBoxCity;
        public System.Windows.Forms.TextBox txtBoxState;
        public System.Windows.Forms.TextBox txtBoxCountry;
        public System.Windows.Forms.CheckBox chkIsActive;
        public System.Windows.Forms.Button btnUpdateSupplier;
        public System.Windows.Forms.Button btnSave;
    }
}