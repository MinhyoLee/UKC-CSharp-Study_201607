namespace Calculator_ver01
{
    partial class standard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(standard));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.Results_Window = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(34, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(100, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(166, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(232, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.operator_click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back.Location = new System.Drawing.Point(298, 118);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 60);
            this.back.TabIndex = 4;
            this.back.Text = "<-";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(298, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 9;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clear);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(232, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 8;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.operator_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(166, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(100, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 6;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(34, 184);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 60);
            this.button10.TabIndex = 5;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(298, 250);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 126);
            this.button11.TabIndex = 14;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.equal);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.Location = new System.Drawing.Point(232, 250);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 13;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(166, 250);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 12;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(100, 250);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 11;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.Location = new System.Drawing.Point(34, 250);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 60);
            this.button15.TabIndex = 10;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.Location = new System.Drawing.Point(232, 316);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 60);
            this.button17.TabIndex = 18;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.operator_click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button18.Location = new System.Drawing.Point(166, 316);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 60);
            this.button18.TabIndex = 17;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button20.Location = new System.Drawing.Point(34, 316);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(126, 60);
            this.button20.TabIndex = 15;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_click);
            // 
            // Results_Window
            // 
            this.Results_Window.Location = new System.Drawing.Point(34, 68);
            this.Results_Window.Name = "Results_Window";
            this.Results_Window.ReadOnly = true;
            this.Results_Window.Size = new System.Drawing.Size(324, 28);
            this.Results_Window.TabIndex = 19;
            this.Results_Window.Text = "0";
            this.Results_Window.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 20;
            // 
            // standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results_Window);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "standard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox Results_Window;
        private System.Windows.Forms.Label label1;
    }
}

