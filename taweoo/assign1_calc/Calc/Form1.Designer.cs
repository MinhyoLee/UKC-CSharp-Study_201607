namespace Calc
{
  partial class Form1
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
      this.txtResultNum = new System.Windows.Forms.TextBox();
      this.btnNum7 = new System.Windows.Forms.Button();
      this.btnNum8 = new System.Windows.Forms.Button();
      this.btnNum9 = new System.Windows.Forms.Button();
      this.btnNum4 = new System.Windows.Forms.Button();
      this.btnNum5 = new System.Windows.Forms.Button();
      this.btnNum6 = new System.Windows.Forms.Button();
      this.btnNum1 = new System.Windows.Forms.Button();
      this.btnNum2 = new System.Windows.Forms.Button();
      this.btnNum3 = new System.Windows.Forms.Button();
      this.btnNum0 = new System.Windows.Forms.Button();
      this.btnNumDot = new System.Windows.Forms.Button();
      this.btnEqual = new System.Windows.Forms.Button();
      this.btnMemory = new System.Windows.Forms.Button();
      this.btnMemoryPlus = new System.Windows.Forms.Button();
      this.btnMemoryMinus = new System.Windows.Forms.Button();
      this.btnDivision = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnMultiplication = new System.Windows.Forms.Button();
      this.btnMinus = new System.Windows.Forms.Button();
      this.btnPlus = new System.Windows.Forms.Button();
      this.txtLastFuntion = new System.Windows.Forms.TextBox();
      this.txtMemoryNum = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtResultNum
      // 
      this.txtResultNum.Location = new System.Drawing.Point(129, 66);
      this.txtResultNum.Name = "txtResultNum";
      this.txtResultNum.ReadOnly = true;
      this.txtResultNum.Size = new System.Drawing.Size(505, 42);
      this.txtResultNum.TabIndex = 0;
      this.txtResultNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnNum7
      // 
      this.btnNum7.Location = new System.Drawing.Point(49, 216);
      this.btnNum7.Name = "btnNum7";
      this.btnNum7.Size = new System.Drawing.Size(142, 88);
      this.btnNum7.TabIndex = 1;
      this.btnNum7.Text = "7";
      this.btnNum7.UseVisualStyleBackColor = true;
      this.btnNum7.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum8
      // 
      this.btnNum8.Location = new System.Drawing.Point(197, 216);
      this.btnNum8.Name = "btnNum8";
      this.btnNum8.Size = new System.Drawing.Size(142, 88);
      this.btnNum8.TabIndex = 1;
      this.btnNum8.Text = "8";
      this.btnNum8.UseVisualStyleBackColor = true;
      this.btnNum8.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum9
      // 
      this.btnNum9.Location = new System.Drawing.Point(345, 215);
      this.btnNum9.Name = "btnNum9";
      this.btnNum9.Size = new System.Drawing.Size(142, 88);
      this.btnNum9.TabIndex = 1;
      this.btnNum9.Text = "9";
      this.btnNum9.UseVisualStyleBackColor = true;
      this.btnNum9.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum4
      // 
      this.btnNum4.Location = new System.Drawing.Point(48, 310);
      this.btnNum4.Name = "btnNum4";
      this.btnNum4.Size = new System.Drawing.Size(142, 88);
      this.btnNum4.TabIndex = 1;
      this.btnNum4.Text = "4";
      this.btnNum4.UseVisualStyleBackColor = true;
      this.btnNum4.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum5
      // 
      this.btnNum5.Location = new System.Drawing.Point(196, 310);
      this.btnNum5.Name = "btnNum5";
      this.btnNum5.Size = new System.Drawing.Size(142, 88);
      this.btnNum5.TabIndex = 1;
      this.btnNum5.Text = "5";
      this.btnNum5.UseVisualStyleBackColor = true;
      this.btnNum5.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum6
      // 
      this.btnNum6.Location = new System.Drawing.Point(344, 309);
      this.btnNum6.Name = "btnNum6";
      this.btnNum6.Size = new System.Drawing.Size(142, 88);
      this.btnNum6.TabIndex = 1;
      this.btnNum6.Text = "6";
      this.btnNum6.UseVisualStyleBackColor = true;
      this.btnNum6.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum1
      // 
      this.btnNum1.Location = new System.Drawing.Point(48, 404);
      this.btnNum1.Name = "btnNum1";
      this.btnNum1.Size = new System.Drawing.Size(142, 88);
      this.btnNum1.TabIndex = 1;
      this.btnNum1.Text = "1";
      this.btnNum1.UseVisualStyleBackColor = true;
      this.btnNum1.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum2
      // 
      this.btnNum2.Location = new System.Drawing.Point(196, 404);
      this.btnNum2.Name = "btnNum2";
      this.btnNum2.Size = new System.Drawing.Size(142, 88);
      this.btnNum2.TabIndex = 1;
      this.btnNum2.Text = "2";
      this.btnNum2.UseVisualStyleBackColor = true;
      this.btnNum2.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum3
      // 
      this.btnNum3.Location = new System.Drawing.Point(344, 403);
      this.btnNum3.Name = "btnNum3";
      this.btnNum3.Size = new System.Drawing.Size(142, 88);
      this.btnNum3.TabIndex = 1;
      this.btnNum3.Text = "3";
      this.btnNum3.UseVisualStyleBackColor = true;
      this.btnNum3.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNum0
      // 
      this.btnNum0.Location = new System.Drawing.Point(48, 498);
      this.btnNum0.Name = "btnNum0";
      this.btnNum0.Size = new System.Drawing.Size(142, 88);
      this.btnNum0.TabIndex = 1;
      this.btnNum0.Text = "0";
      this.btnNum0.UseVisualStyleBackColor = true;
      this.btnNum0.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnNumDot
      // 
      this.btnNumDot.Location = new System.Drawing.Point(196, 498);
      this.btnNumDot.Name = "btnNumDot";
      this.btnNumDot.Size = new System.Drawing.Size(142, 88);
      this.btnNumDot.TabIndex = 1;
      this.btnNumDot.Text = ".";
      this.btnNumDot.UseVisualStyleBackColor = true;
      this.btnNumDot.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // btnEqual
      // 
      this.btnEqual.Location = new System.Drawing.Point(344, 497);
      this.btnEqual.Name = "btnEqual";
      this.btnEqual.Size = new System.Drawing.Size(142, 88);
      this.btnEqual.TabIndex = 1;
      this.btnEqual.Text = "=";
      this.btnEqual.UseVisualStyleBackColor = true;
      this.btnEqual.Click += new System.EventHandler(this.btnFunction_Click);
      // 
      // btnMemory
      // 
      this.btnMemory.Location = new System.Drawing.Point(51, 122);
      this.btnMemory.Name = "btnMemory";
      this.btnMemory.Size = new System.Drawing.Size(142, 88);
      this.btnMemory.TabIndex = 1;
      this.btnMemory.Text = "MR";
      this.btnMemory.UseVisualStyleBackColor = true;
      this.btnMemory.Click += new System.EventHandler(this.btnMemoryFunction_Click);
      // 
      // btnMemoryPlus
      // 
      this.btnMemoryPlus.Location = new System.Drawing.Point(199, 122);
      this.btnMemoryPlus.Name = "btnMemoryPlus";
      this.btnMemoryPlus.Size = new System.Drawing.Size(142, 88);
      this.btnMemoryPlus.TabIndex = 1;
      this.btnMemoryPlus.Text = "M+";
      this.btnMemoryPlus.UseVisualStyleBackColor = true;
      this.btnMemoryPlus.Click += new System.EventHandler(this.btnMemoryFunction_Click);
      // 
      // btnMemoryMinus
      // 
      this.btnMemoryMinus.Location = new System.Drawing.Point(347, 121);
      this.btnMemoryMinus.Name = "btnMemoryMinus";
      this.btnMemoryMinus.Size = new System.Drawing.Size(142, 88);
      this.btnMemoryMinus.TabIndex = 1;
      this.btnMemoryMinus.Text = "M-";
      this.btnMemoryMinus.UseVisualStyleBackColor = true;
      this.btnMemoryMinus.Click += new System.EventHandler(this.btnMemoryFunction_Click);
      // 
      // btnDivision
      // 
      this.btnDivision.Location = new System.Drawing.Point(493, 216);
      this.btnDivision.Name = "btnDivision";
      this.btnDivision.Size = new System.Drawing.Size(142, 88);
      this.btnDivision.TabIndex = 1;
      this.btnDivision.Text = "/";
      this.btnDivision.UseVisualStyleBackColor = true;
      this.btnDivision.Click += new System.EventHandler(this.btnFunction_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(495, 122);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(142, 88);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "AC";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnMultiplication
      // 
      this.btnMultiplication.Location = new System.Drawing.Point(492, 310);
      this.btnMultiplication.Name = "btnMultiplication";
      this.btnMultiplication.Size = new System.Drawing.Size(142, 88);
      this.btnMultiplication.TabIndex = 1;
      this.btnMultiplication.Text = "X";
      this.btnMultiplication.UseVisualStyleBackColor = true;
      this.btnMultiplication.Click += new System.EventHandler(this.btnFunction_Click);
      // 
      // btnMinus
      // 
      this.btnMinus.Location = new System.Drawing.Point(492, 404);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(142, 88);
      this.btnMinus.TabIndex = 1;
      this.btnMinus.Text = "-";
      this.btnMinus.UseVisualStyleBackColor = true;
      this.btnMinus.Click += new System.EventHandler(this.btnFunction_Click);
      // 
      // btnPlus
      // 
      this.btnPlus.Location = new System.Drawing.Point(492, 498);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(142, 88);
      this.btnPlus.TabIndex = 1;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnFunction_Click);
      // 
      // txtLastFuntion
      // 
      this.txtLastFuntion.Location = new System.Drawing.Point(51, 66);
      this.txtLastFuntion.Name = "txtLastFuntion";
      this.txtLastFuntion.ReadOnly = true;
      this.txtLastFuntion.Size = new System.Drawing.Size(72, 42);
      this.txtLastFuntion.TabIndex = 2;
      this.txtLastFuntion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtMemoryNum
      // 
      this.txtMemoryNum.Location = new System.Drawing.Point(190, 12);
      this.txtMemoryNum.Name = "txtMemoryNum";
      this.txtMemoryNum.ReadOnly = true;
      this.txtMemoryNum.Size = new System.Drawing.Size(444, 42);
      this.txtMemoryNum.TabIndex = 0;
      this.txtMemoryNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(54, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 30);
      this.label1.TabIndex = 3;
      this.label1.Text = "memory";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(668, 642);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtLastFuntion);
      this.Controls.Add(this.btnPlus);
      this.Controls.Add(this.btnMinus);
      this.Controls.Add(this.btnEqual);
      this.Controls.Add(this.btnMultiplication);
      this.Controls.Add(this.btnNum3);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnNum6);
      this.Controls.Add(this.btnDivision);
      this.Controls.Add(this.btnMemoryMinus);
      this.Controls.Add(this.btnNum9);
      this.Controls.Add(this.btnNumDot);
      this.Controls.Add(this.btnNum2);
      this.Controls.Add(this.btnNum5);
      this.Controls.Add(this.btnMemoryPlus);
      this.Controls.Add(this.btnNum8);
      this.Controls.Add(this.btnNum0);
      this.Controls.Add(this.btnNum1);
      this.Controls.Add(this.btnNum4);
      this.Controls.Add(this.btnMemory);
      this.Controls.Add(this.btnNum7);
      this.Controls.Add(this.txtMemoryNum);
      this.Controls.Add(this.txtResultNum);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtResultNum;
    private System.Windows.Forms.Button btnNum7;
    private System.Windows.Forms.Button btnNum8;
    private System.Windows.Forms.Button btnNum9;
    private System.Windows.Forms.Button btnNum4;
    private System.Windows.Forms.Button btnNum5;
    private System.Windows.Forms.Button btnNum6;
    private System.Windows.Forms.Button btnNum1;
    private System.Windows.Forms.Button btnNum2;
    private System.Windows.Forms.Button btnNum3;
    private System.Windows.Forms.Button btnNum0;
    private System.Windows.Forms.Button btnNumDot;
    private System.Windows.Forms.Button btnEqual;
    private System.Windows.Forms.Button btnMemory;
    private System.Windows.Forms.Button btnMemoryPlus;
    private System.Windows.Forms.Button btnMemoryMinus;
    private System.Windows.Forms.Button btnDivision;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnMultiplication;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.TextBox txtLastFuntion;
    private System.Windows.Forms.TextBox txtMemoryNum;
    private System.Windows.Forms.Label label1;
  }
}

