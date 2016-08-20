namespace NamaCard
{
  partial class NamacardMng
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.txtAddr = new System.Windows.Forms.TextBox();
      this.txtCompany = new System.Windows.Forms.TextBox();
      this.txtMail = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSearch = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.txtSearchText = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "이름";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(106, 24);
      this.label2.TabIndex = 0;
      this.label2.Text = "전화번호";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 173);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 24);
      this.label3.TabIndex = 0;
      this.label3.Text = "주소";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(21, 95);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(82, 24);
      this.label4.TabIndex = 0;
      this.label4.Text = "회사명";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(21, 134);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 24);
      this.label5.TabIndex = 0;
      this.label5.Text = "이메일";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(165, 13);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(430, 35);
      this.txtName.TabIndex = 1;
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(165, 52);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(430, 35);
      this.txtPhone.TabIndex = 2;
      // 
      // txtAddr
      // 
      this.txtAddr.Location = new System.Drawing.Point(165, 168);
      this.txtAddr.Multiline = true;
      this.txtAddr.Name = "txtAddr";
      this.txtAddr.Size = new System.Drawing.Size(430, 118);
      this.txtAddr.TabIndex = 5;
      // 
      // txtCompany
      // 
      this.txtCompany.Location = new System.Drawing.Point(165, 90);
      this.txtCompany.Name = "txtCompany";
      this.txtCompany.Size = new System.Drawing.Size(430, 35);
      this.txtCompany.TabIndex = 3;
      // 
      // txtMail
      // 
      this.txtMail.Location = new System.Drawing.Point(165, 129);
      this.txtMail.Name = "txtMail";
      this.txtMail.Size = new System.Drawing.Size(430, 35);
      this.txtMail.TabIndex = 4;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.id,
            this.PhoneNo,
            this.Email,
            this.CompanyName,
            this.Adress});
      this.dataGridView1.Location = new System.Drawing.Point(13, 391);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 37;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(1602, 600);
      this.dataGridView1.TabIndex = 99;
      // 
      // Name
      // 
      this.Name.DataPropertyName = "Name";
      this.Name.HeaderText = "이름";
      this.Name.Name = "Name";
      this.Name.ReadOnly = true;
      // 
      // id
      // 
      this.id.DataPropertyName = "_id";
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Visible = false;
      // 
      // PhoneNo
      // 
      this.PhoneNo.DataPropertyName = "PhoneNo";
      this.PhoneNo.HeaderText = "전화번호";
      this.PhoneNo.Name = "PhoneNo";
      this.PhoneNo.ReadOnly = true;
      // 
      // Email
      // 
      this.Email.DataPropertyName = "Email";
      this.Email.HeaderText = "이메일";
      this.Email.Name = "Email";
      this.Email.ReadOnly = true;
      // 
      // CompanyName
      // 
      this.CompanyName.DataPropertyName = "CompanyName";
      this.CompanyName.HeaderText = "회사명";
      this.CompanyName.Name = "CompanyName";
      this.CompanyName.ReadOnly = true;
      // 
      // Adress
      // 
      this.Adress.DataPropertyName = "Adress";
      this.Adress.HeaderText = "주소";
      this.Adress.Name = "Adress";
      this.Adress.ReadOnly = true;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(896, 332);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(141, 53);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "조회";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 332);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(141, 53);
      this.button1.TabIndex = 3;
      this.button1.Text = "추가";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(159, 332);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(141, 53);
      this.button2.TabIndex = 3;
      this.button2.Text = "삭제";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(306, 332);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(141, 53);
      this.button3.TabIndex = 3;
      this.button3.Text = "초기화";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // txtSearchText
      // 
      this.txtSearchText.Location = new System.Drawing.Point(600, 343);
      this.txtSearchText.Name = "txtSearchText";
      this.txtSearchText.Size = new System.Drawing.Size(290, 35);
      this.txtSearchText.TabIndex = 100;
      // 
      // NamacardMng
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1627, 1020);
      this.Controls.Add(this.txtSearchText);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.txtMail);
      this.Controls.Add(this.txtCompany);
      this.Controls.Add(this.txtAddr);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Text = "명함관리";
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource bindingSource1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txtAddr;
    private System.Windows.Forms.TextBox txtCompany;
    private System.Windows.Forms.TextBox txtMail;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
    private System.Windows.Forms.TextBox txtSearchText;
  }
}

