namespace Calculator
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
            this.num0Button = new System.Windows.Forms.Button();
            this.calculatorLabel = new System.Windows.Forms.Label();
            this.dotButton = new System.Windows.Forms.Button();
            this.num1Button = new System.Windows.Forms.Button();
            this.num2Button = new System.Windows.Forms.Button();
            this.num3Button = new System.Windows.Forms.Button();
            this.num6Button = new System.Windows.Forms.Button();
            this.num5Button = new System.Windows.Forms.Button();
            this.num4Button = new System.Windows.Forms.Button();
            this.num9Button = new System.Windows.Forms.Button();
            this.num8Button = new System.Windows.Forms.Button();
            this.num7Button = new System.Windows.Forms.Button();
            this.memorySaveButton = new System.Windows.Forms.Button();
            this.memoryReadButton = new System.Windows.Forms.Button();
            this.memoryCleanButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.negateButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.calculatorTopLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num0Button
            // 
            this.num0Button.Location = new System.Drawing.Point(89, 300);
            this.num0Button.Name = "num0Button";
            this.num0Button.Size = new System.Drawing.Size(45, 38);
            this.num0Button.TabIndex = 0;
            this.num0Button.Text = "0";
            this.num0Button.UseVisualStyleBackColor = true;
            this.num0Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // calculatorLabel
            // 
            this.calculatorLabel.BackColor = System.Drawing.Color.White;
            this.calculatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculatorLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.calculatorLabel.Location = new System.Drawing.Point(23, 20);
            this.calculatorLabel.Name = "calculatorLabel";
            this.calculatorLabel.Size = new System.Drawing.Size(290, 54);
            this.calculatorLabel.TabIndex = 1;
            this.calculatorLabel.Text = "0";
            this.calculatorLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(147, 300);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(45, 38);
            this.dotButton.TabIndex = 3;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // num1Button
            // 
            this.num1Button.Location = new System.Drawing.Point(33, 253);
            this.num1Button.Name = "num1Button";
            this.num1Button.Size = new System.Drawing.Size(45, 38);
            this.num1Button.TabIndex = 4;
            this.num1Button.Text = "1";
            this.num1Button.UseVisualStyleBackColor = true;
            this.num1Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num2Button
            // 
            this.num2Button.Location = new System.Drawing.Point(89, 253);
            this.num2Button.Name = "num2Button";
            this.num2Button.Size = new System.Drawing.Size(45, 38);
            this.num2Button.TabIndex = 5;
            this.num2Button.Text = "2";
            this.num2Button.UseVisualStyleBackColor = true;
            this.num2Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num3Button
            // 
            this.num3Button.Location = new System.Drawing.Point(147, 253);
            this.num3Button.Name = "num3Button";
            this.num3Button.Size = new System.Drawing.Size(45, 38);
            this.num3Button.TabIndex = 6;
            this.num3Button.Text = "3";
            this.num3Button.UseVisualStyleBackColor = true;
            this.num3Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num6Button
            // 
            this.num6Button.Location = new System.Drawing.Point(147, 207);
            this.num6Button.Name = "num6Button";
            this.num6Button.Size = new System.Drawing.Size(45, 38);
            this.num6Button.TabIndex = 9;
            this.num6Button.Text = "6";
            this.num6Button.UseVisualStyleBackColor = true;
            this.num6Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num5Button
            // 
            this.num5Button.Location = new System.Drawing.Point(89, 207);
            this.num5Button.Name = "num5Button";
            this.num5Button.Size = new System.Drawing.Size(45, 38);
            this.num5Button.TabIndex = 8;
            this.num5Button.Text = "5";
            this.num5Button.UseVisualStyleBackColor = true;
            this.num5Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num4Button
            // 
            this.num4Button.Location = new System.Drawing.Point(33, 207);
            this.num4Button.Name = "num4Button";
            this.num4Button.Size = new System.Drawing.Size(45, 38);
            this.num4Button.TabIndex = 7;
            this.num4Button.Text = "4";
            this.num4Button.UseVisualStyleBackColor = true;
            this.num4Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num9Button
            // 
            this.num9Button.Location = new System.Drawing.Point(147, 163);
            this.num9Button.Name = "num9Button";
            this.num9Button.Size = new System.Drawing.Size(45, 38);
            this.num9Button.TabIndex = 12;
            this.num9Button.Text = "9";
            this.num9Button.UseVisualStyleBackColor = true;
            this.num9Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num8Button
            // 
            this.num8Button.Location = new System.Drawing.Point(89, 163);
            this.num8Button.Name = "num8Button";
            this.num8Button.Size = new System.Drawing.Size(45, 38);
            this.num8Button.TabIndex = 11;
            this.num8Button.Text = "8";
            this.num8Button.UseVisualStyleBackColor = true;
            this.num8Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // num7Button
            // 
            this.num7Button.Location = new System.Drawing.Point(33, 163);
            this.num7Button.Name = "num7Button";
            this.num7Button.Size = new System.Drawing.Size(45, 38);
            this.num7Button.TabIndex = 10;
            this.num7Button.Text = "7";
            this.num7Button.UseVisualStyleBackColor = true;
            this.num7Button.Click += new System.EventHandler(this.numButton_Click);
            // 
            // memorySaveButton
            // 
            this.memorySaveButton.Location = new System.Drawing.Point(147, 119);
            this.memorySaveButton.Name = "memorySaveButton";
            this.memorySaveButton.Size = new System.Drawing.Size(45, 38);
            this.memorySaveButton.TabIndex = 15;
            this.memorySaveButton.Text = "MS";
            this.memorySaveButton.UseVisualStyleBackColor = true;
            this.memorySaveButton.Click += new System.EventHandler(this.memorySaveButton_Click);
            // 
            // memoryReadButton
            // 
            this.memoryReadButton.Location = new System.Drawing.Point(89, 119);
            this.memoryReadButton.Name = "memoryReadButton";
            this.memoryReadButton.Size = new System.Drawing.Size(45, 38);
            this.memoryReadButton.TabIndex = 14;
            this.memoryReadButton.Text = "MR";
            this.memoryReadButton.UseVisualStyleBackColor = true;
            this.memoryReadButton.Click += new System.EventHandler(this.memoryReadButton_Click);
            // 
            // memoryCleanButton
            // 
            this.memoryCleanButton.Location = new System.Drawing.Point(33, 119);
            this.memoryCleanButton.Name = "memoryCleanButton";
            this.memoryCleanButton.Size = new System.Drawing.Size(45, 38);
            this.memoryCleanButton.TabIndex = 13;
            this.memoryCleanButton.Text = "MC";
            this.memoryCleanButton.UseVisualStyleBackColor = true;
            this.memoryCleanButton.Click += new System.EventHandler(this.memoryCleanButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(205, 163);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(45, 38);
            this.divButton.TabIndex = 19;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(205, 207);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(45, 38);
            this.mulButton.TabIndex = 18;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(205, 253);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(45, 38);
            this.subButton.TabIndex = 17;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(205, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(45, 38);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(205, 119);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 38);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(256, 163);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(45, 38);
            this.CleanButton.TabIndex = 22;
            this.CleanButton.Text = "C";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // negateButton
            // 
            this.negateButton.Location = new System.Drawing.Point(33, 300);
            this.negateButton.Name = "negateButton";
            this.negateButton.Size = new System.Drawing.Size(45, 38);
            this.negateButton.TabIndex = 21;
            this.negateButton.Text = "+-";
            this.negateButton.UseVisualStyleBackColor = true;
            this.negateButton.Click += new System.EventHandler(this.negateButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(256, 207);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(45, 131);
            this.equalButton.TabIndex = 24;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.BackColor = System.Drawing.Color.White;
            this.memoryLabel.Location = new System.Drawing.Point(26, 58);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(0, 12);
            this.memoryLabel.TabIndex = 27;
            // 
            // calculatorTopLabel
            // 
            this.calculatorTopLabel.BackColor = System.Drawing.Color.White;
            this.calculatorTopLabel.Location = new System.Drawing.Point(27, 22);
            this.calculatorTopLabel.Name = "calculatorTopLabel";
            this.calculatorTopLabel.Size = new System.Drawing.Size(286, 22);
            this.calculatorTopLabel.TabIndex = 28;
            this.calculatorTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 362);
            this.Controls.Add(this.calculatorTopLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.negateButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.memorySaveButton);
            this.Controls.Add(this.memoryReadButton);
            this.Controls.Add(this.memoryCleanButton);
            this.Controls.Add(this.num9Button);
            this.Controls.Add(this.num8Button);
            this.Controls.Add(this.num7Button);
            this.Controls.Add(this.num6Button);
            this.Controls.Add(this.num5Button);
            this.Controls.Add(this.num4Button);
            this.Controls.Add(this.num3Button);
            this.Controls.Add(this.num2Button);
            this.Controls.Add(this.num1Button);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.calculatorLabel);
            this.Controls.Add(this.num0Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num0Button;
        private System.Windows.Forms.Label calculatorLabel;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button num1Button;
        private System.Windows.Forms.Button num2Button;
        private System.Windows.Forms.Button num3Button;
        private System.Windows.Forms.Button num6Button;
        private System.Windows.Forms.Button num5Button;
        private System.Windows.Forms.Button num4Button;
        private System.Windows.Forms.Button num9Button;
        private System.Windows.Forms.Button num8Button;
        private System.Windows.Forms.Button num7Button;
        private System.Windows.Forms.Button memorySaveButton;
        private System.Windows.Forms.Button memoryReadButton;
        private System.Windows.Forms.Button memoryCleanButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button negateButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label calculatorTopLabel;
    }
}

