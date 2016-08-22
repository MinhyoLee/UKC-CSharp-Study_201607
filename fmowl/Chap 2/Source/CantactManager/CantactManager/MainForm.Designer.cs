namespace CantactManager
{
    partial class mainForm
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
            this.searchingTextBox = new System.Windows.Forms.TextBox();
            this.searchingButton = new System.Windows.Forms.Button();
            this.deletItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.includeCheckBox = new System.Windows.Forms.CheckBox();
            this.excludeCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchingTextBox
            // 
            this.searchingTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchingTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchingTextBox.Multiline = true;
            this.searchingTextBox.Name = "searchingTextBox";
            this.searchingTextBox.Size = new System.Drawing.Size(337, 35);
            this.searchingTextBox.TabIndex = 0;
            // 
            // searchingButton
            // 
            this.searchingButton.Location = new System.Drawing.Point(367, 12);
            this.searchingButton.Name = "searchingButton";
            this.searchingButton.Size = new System.Drawing.Size(86, 35);
            this.searchingButton.TabIndex = 1;
            this.searchingButton.Text = "검색";
            this.searchingButton.UseVisualStyleBackColor = true;
            this.searchingButton.Click += new System.EventHandler(this.searchingButton_Click);
            // 
            // deletItemButton
            // 
            this.deletItemButton.Location = new System.Drawing.Point(12, 63);
            this.deletItemButton.Name = "deletItemButton";
            this.deletItemButton.Size = new System.Drawing.Size(75, 35);
            this.deletItemButton.TabIndex = 2;
            this.deletItemButton.Text = "제거";
            this.deletItemButton.UseVisualStyleBackColor = true;
            this.deletItemButton.Click += new System.EventHandler(this.deletItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(93, 63);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 35);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "추가";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // includeCheckBox
            // 
            this.includeCheckBox.AutoSize = true;
            this.includeCheckBox.Location = new System.Drawing.Point(367, 60);
            this.includeCheckBox.Name = "includeCheckBox";
            this.includeCheckBox.Size = new System.Drawing.Size(48, 16);
            this.includeCheckBox.TabIndex = 4;
            this.includeCheckBox.Text = "포함";
            this.includeCheckBox.UseVisualStyleBackColor = true;
            // 
            // excludeCheckBox
            // 
            this.excludeCheckBox.AutoSize = true;
            this.excludeCheckBox.Location = new System.Drawing.Point(367, 82);
            this.excludeCheckBox.Name = "excludeCheckBox";
            this.excludeCheckBox.Size = new System.Drawing.Size(48, 16);
            this.excludeCheckBox.TabIndex = 5;
            this.excludeCheckBox.Text = "제외";
            this.excludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 376);
            this.listBox1.TabIndex = 6;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 519);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.excludeCheckBox);
            this.Controls.Add(this.includeCheckBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.deletItemButton);
            this.Controls.Add(this.searchingButton);
            this.Controls.Add(this.searchingTextBox);
            this.Name = "mainForm";
            this.Text = "연락처 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchingTextBox;
        private System.Windows.Forms.Button searchingButton;
        private System.Windows.Forms.Button deletItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.CheckBox includeCheckBox;
        private System.Windows.Forms.CheckBox excludeCheckBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

