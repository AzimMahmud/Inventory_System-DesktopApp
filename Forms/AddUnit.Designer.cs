namespace UltimateInventorySystem.Forms
{
    partial class AddUnit
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
            this.lblAddUnit = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtBoxUnitName = new System.Windows.Forms.TextBox();
            this.txtBoxUnitShortName = new System.Windows.Forms.TextBox();
            this.lblUntiShortName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAddUnit
            // 
            this.lblAddUnit.AutoSize = true;
            this.lblAddUnit.Font = new System.Drawing.Font("Century Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblAddUnit.Location = new System.Drawing.Point(312, 19);
            this.lblAddUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddUnit.Name = "lblAddUnit";
            this.lblAddUnit.Size = new System.Drawing.Size(174, 26);
            this.lblAddUnit.TabIndex = 0;
            this.lblAddUnit.Text = "Add a new unit";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblUnitName.Location = new System.Drawing.Point(139, 113);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(115, 22);
            this.lblUnitName.TabIndex = 1;
            this.lblUnitName.Text = "Unit Name :";
            // 
            // txtBoxUnitName
            // 
            this.txtBoxUnitName.Location = new System.Drawing.Point(330, 111);
            this.txtBoxUnitName.Multiline = true;
            this.txtBoxUnitName.Name = "txtBoxUnitName";
            this.txtBoxUnitName.Size = new System.Drawing.Size(250, 35);
            this.txtBoxUnitName.TabIndex = 2;
            // 
            // txtBoxUnitShortName
            // 
            this.txtBoxUnitShortName.Location = new System.Drawing.Point(330, 193);
            this.txtBoxUnitShortName.Multiline = true;
            this.txtBoxUnitShortName.Name = "txtBoxUnitShortName";
            this.txtBoxUnitShortName.Size = new System.Drawing.Size(250, 35);
            this.txtBoxUnitShortName.TabIndex = 4;
            // 
            // lblUntiShortName
            // 
            this.lblUntiShortName.AutoSize = true;
            this.lblUntiShortName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUntiShortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.lblUntiShortName.Location = new System.Drawing.Point(139, 195);
            this.lblUntiShortName.Name = "lblUntiShortName";
            this.lblUntiShortName.Size = new System.Drawing.Size(127, 22);
            this.lblUntiShortName.TabIndex = 3;
            this.lblUntiShortName.Text = "Short Name :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(256, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(430, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(231)))));
            this.chkIsActive.Location = new System.Drawing.Point(330, 250);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(110, 25);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "Is Active ?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // AddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxUnitShortName);
            this.Controls.Add(this.lblUntiShortName);
            this.Controls.Add(this.txtBoxUnitName);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.lblAddUnit);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddUnit";
            this.Text = "AddUnit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUnit;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.TextBox txtBoxUnitName;
        private System.Windows.Forms.TextBox txtBoxUnitShortName;
        private System.Windows.Forms.Label lblUntiShortName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}