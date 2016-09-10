namespace Housekeeping
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImport = new System.Windows.Forms.Label();
            this.labelImport = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.labelExport = new System.Windows.Forms.Label();
            this.listToday = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblToday = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(45, 37);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(37, 15);
            this.lblImport.TabIndex = 0;
            this.lblImport.Text = "수입";
            // 
            // labelImport
            // 
            this.labelImport.AutoSize = true;
            this.labelImport.Location = new System.Drawing.Point(143, 37);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(22, 15);
            this.labelImport.TabIndex = 1;
            this.labelImport.Text = "원";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(143, 110);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(22, 15);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "원";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(45, 110);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(37, 15);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "잔고";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(45, 75);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(37, 15);
            this.lblExport.TabIndex = 2;
            this.lblExport.Text = "지출";
            // 
            // labelExport
            // 
            this.labelExport.AutoSize = true;
            this.labelExport.Location = new System.Drawing.Point(143, 75);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(22, 15);
            this.labelExport.TabIndex = 3;
            this.labelExport.Text = "원";
            // 
            // listToday
            // 
            this.listToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listToday.Location = new System.Drawing.Point(48, 199);
            this.listToday.Name = "listToday";
            this.listToday.Size = new System.Drawing.Size(504, 151);
            this.listToday.TabIndex = 4;
            this.listToday.UseCompatibleStateImageBehavior = false;
            this.listToday.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "수입/지출";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "분류";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "현금/카드";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "금액";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "거래처";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(45, 181);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(12, 15);
            this.lblToday.TabIndex = 5;
            this.lblToday.Text = ".";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(573, 37);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 53);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "입력";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 375);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.listToday);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.labelImport);
            this.Controls.Add(this.lblImport);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label labelImport;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label labelExport;
        private System.Windows.Forms.ListView listToday;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Button btnEnter;
    }
}

