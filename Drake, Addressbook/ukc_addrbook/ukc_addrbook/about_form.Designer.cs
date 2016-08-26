namespace ukc_addrbook
{
    partial class about_form
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.llb1 = new System.Windows.Forms.LinkLabel();
            this.llb2 = new System.Windows.Forms.LinkLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(150, 12);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Ubuntu Korea Community";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 21);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(203, 12);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Season 3 - C# Programming Study";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 33);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(218, 12);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Episode 2 : Address Book Application";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(12, 45);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(85, 12);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "Author : Drake";
            // 
            // llb1
            // 
            this.llb1.AutoSize = true;
            this.llb1.Location = new System.Drawing.Point(13, 61);
            this.llb1.Name = "llb1";
            this.llb1.Size = new System.Drawing.Size(63, 12);
            this.llb1.TabIndex = 4;
            this.llb1.TabStop = true;
            this.llb1.Text = "Study Wiki";
            this.llb1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb1_LinkClicked);
            // 
            // llb2
            // 
            this.llb2.AutoSize = true;
            this.llb2.Location = new System.Drawing.Point(83, 60);
            this.llb2.Name = "llb2";
            this.llb2.Size = new System.Drawing.Size(79, 12);
            this.llb2.TabIndex = 5;
            this.llb2.TabStop = true;
            this.llb2.Text = "Source Code";
            this.llb2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb2_LinkClicked);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Okay";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // about_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.llb2);
            this.Controls.Add(this.llb1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "about_form";
            this.Text = "about_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.LinkLabel llb1;
        private System.Windows.Forms.LinkLabel llb2;
        private System.Windows.Forms.Button btnOk;
    }
}