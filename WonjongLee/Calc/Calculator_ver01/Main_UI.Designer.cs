namespace Calculator_ver01
{
    partial class Main_UI
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
            this.standard_btn = new System.Windows.Forms.Button();
            this.convert_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standard_btn
            // 
            this.standard_btn.Location = new System.Drawing.Point(46, 56);
            this.standard_btn.Name = "standard_btn";
            this.standard_btn.Size = new System.Drawing.Size(190, 99);
            this.standard_btn.TabIndex = 0;
            this.standard_btn.Text = "표준 계산기";
            this.standard_btn.UseVisualStyleBackColor = true;
            this.standard_btn.Click += new System.EventHandler(this.standard_btn_Click);
            // 
            // convert_btn
            // 
            this.convert_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.convert_btn.Location = new System.Drawing.Point(280, 56);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(190, 99);
            this.convert_btn.TabIndex = 1;
            this.convert_btn.Text = "진수변환";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 219);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.standard_btn);
            this.Name = "Main_UI";
            this.Text = "Main_UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button standard_btn;
        private System.Windows.Forms.Button convert_btn;
    }
}