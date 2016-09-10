namespace Housekeeping
{
    partial class InputForm
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
            this.rdbImport = new System.Windows.Forms.RadioButton();
            this.rdbExport = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblUselist = new System.Windows.Forms.Label();
            this.cboUseList = new System.Windows.Forms.ComboBox();
            this.lblCashcard = new System.Windows.Forms.Label();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.rdbCard = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbImport
            // 
            this.rdbImport.AutoSize = true;
            this.rdbImport.Location = new System.Drawing.Point(97, 56);
            this.rdbImport.Name = "rdbImport";
            this.rdbImport.Size = new System.Drawing.Size(58, 19);
            this.rdbImport.TabIndex = 0;
            this.rdbImport.TabStop = true;
            this.rdbImport.Text = "수입";
            this.rdbImport.UseVisualStyleBackColor = true;
            // 
            // rdbExport
            // 
            this.rdbExport.AutoSize = true;
            this.rdbExport.Location = new System.Drawing.Point(186, 56);
            this.rdbExport.Name = "rdbExport";
            this.rdbExport.Size = new System.Drawing.Size(58, 19);
            this.rdbExport.TabIndex = 1;
            this.rdbExport.TabStop = true;
            this.rdbExport.Text = "지출";
            this.rdbExport.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(33, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "날짜";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblUselist
            // 
            this.lblUselist.AutoSize = true;
            this.lblUselist.Location = new System.Drawing.Point(33, 141);
            this.lblUselist.Name = "lblUselist";
            this.lblUselist.Size = new System.Drawing.Size(37, 15);
            this.lblUselist.TabIndex = 2;
            this.lblUselist.Text = "분류";
            // 
            // cboUseList
            // 
            this.cboUseList.FormattingEnabled = true;
            this.cboUseList.Location = new System.Drawing.Point(97, 132);
            this.cboUseList.Name = "cboUseList";
            this.cboUseList.Size = new System.Drawing.Size(121, 23);
            this.cboUseList.TabIndex = 4;
            // 
            // lblCashcard
            // 
            this.lblCashcard.AutoSize = true;
            this.lblCashcard.Location = new System.Drawing.Point(33, 179);
            this.lblCashcard.Name = "lblCashcard";
            this.lblCashcard.Size = new System.Drawing.Size(37, 15);
            this.lblCashcard.TabIndex = 2;
            this.lblCashcard.Text = "계좌";
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(97, 175);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(58, 19);
            this.rdbCash.TabIndex = 0;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "현금";
            this.rdbCash.UseVisualStyleBackColor = true;
            // 
            // rdbCard
            // 
            this.rdbCard.AutoSize = true;
            this.rdbCard.Location = new System.Drawing.Point(186, 175);
            this.rdbCard.Name = "rdbCard";
            this.rdbCard.Size = new System.Drawing.Size(58, 19);
            this.rdbCard.TabIndex = 1;
            this.rdbCard.TabStop = true;
            this.rdbCard.Text = "카드";
            this.rdbCard.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(33, 216);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(37, 15);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "금액";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(97, 206);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 25);
            this.txtAmount.TabIndex = 5;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(33, 254);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(52, 15);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "거래처";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(97, 244);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 25);
            this.txtCustomer.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 390);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cboUseList);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCashcard);
            this.Controls.Add(this.lblUselist);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rdbCard);
            this.Controls.Add(this.rdbCash);
            this.Controls.Add(this.rdbExport);
            this.Controls.Add(this.rdbImport);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbImport;
        private System.Windows.Forms.RadioButton rdbExport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblUselist;
        private System.Windows.Forms.ComboBox cboUseList;
        private System.Windows.Forms.Label lblCashcard;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.RadioButton rdbCard;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnSave;
    }
}