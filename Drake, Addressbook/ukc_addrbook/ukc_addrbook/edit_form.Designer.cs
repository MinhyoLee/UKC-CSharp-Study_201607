namespace ukc_addrbook
{
    partial class edit_form
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbCompanyTel = new System.Windows.Forms.TextBox();
            this.tbCompanyFax = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbCompanyPhone = new System.Windows.Forms.Label();
            this.lbCompanyFax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(172, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 0;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(172, 39);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 21);
            this.tbPhone.TabIndex = 1;
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(172, 66);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(100, 21);
            this.tbCompany.TabIndex = 2;
            // 
            // tbCompanyTel
            // 
            this.tbCompanyTel.Location = new System.Drawing.Point(172, 93);
            this.tbCompanyTel.Name = "tbCompanyTel";
            this.tbCompanyTel.Size = new System.Drawing.Size(100, 21);
            this.tbCompanyTel.TabIndex = 3;
            // 
            // tbCompanyFax
            // 
            this.tbCompanyFax.Location = new System.Drawing.Point(172, 120);
            this.tbCompanyFax.Name = "tbCompanyFax";
            this.tbCompanyFax.Size = new System.Drawing.Size(100, 21);
            this.tbCompanyFax.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(197, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(116, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Add";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "이름";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(13, 47);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 12);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "휴대폰";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(13, 74);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(29, 12);
            this.lbCompany.TabIndex = 9;
            this.lbCompany.Text = "회사";
            // 
            // lbCompanyPhone
            // 
            this.lbCompanyPhone.AutoSize = true;
            this.lbCompanyPhone.Location = new System.Drawing.Point(13, 101);
            this.lbCompanyPhone.Name = "lbCompanyPhone";
            this.lbCompanyPhone.Size = new System.Drawing.Size(81, 12);
            this.lbCompanyPhone.TabIndex = 10;
            this.lbCompanyPhone.Text = "회사 전화번호";
            // 
            // lbCompanyFax
            // 
            this.lbCompanyFax.AutoSize = true;
            this.lbCompanyFax.Location = new System.Drawing.Point(13, 128);
            this.lbCompanyFax.Name = "lbCompanyFax";
            this.lbCompanyFax.Size = new System.Drawing.Size(81, 12);
            this.lbCompanyFax.TabIndex = 11;
            this.lbCompanyFax.Text = "회사 팩스번호";
            // 
            // edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbCompanyFax);
            this.Controls.Add(this.lbCompanyPhone);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCompanyFax);
            this.Controls.Add(this.tbCompanyTel);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_form";
            this.Text = "Add or Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbCompanyTel;
        private System.Windows.Forms.TextBox tbCompanyFax;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbCompanyPhone;
        private System.Windows.Forms.Label lbCompanyFax;
    }
}