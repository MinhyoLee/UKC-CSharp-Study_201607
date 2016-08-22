namespace CantactManager
{
    partial class EditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cantactTextBox = new System.Windows.Forms.TextBox();
            this.kindOfCantactTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.cantactLabel = new System.Windows.Forms.Label();
            this.kindOfCantactLabel = new System.Windows.Forms.Label();
            this.nameEdit = new System.Windows.Forms.Button();
            this.cantactEdit = new System.Windows.Forms.Button();
            this.kindOfCantactEdit = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(87, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // cantactTextBox
            // 
            this.cantactTextBox.Location = new System.Drawing.Point(87, 39);
            this.cantactTextBox.Name = "cantactTextBox";
            this.cantactTextBox.Size = new System.Drawing.Size(164, 21);
            this.cantactTextBox.TabIndex = 1;
            // 
            // kindOfCantactTextBox
            // 
            this.kindOfCantactTextBox.Location = new System.Drawing.Point(87, 66);
            this.kindOfCantactTextBox.Name = "kindOfCantactTextBox";
            this.kindOfCantactTextBox.Size = new System.Drawing.Size(164, 21);
            this.kindOfCantactTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "이름";
            // 
            // cantactLabel
            // 
            this.cantactLabel.AutoSize = true;
            this.cantactLabel.Location = new System.Drawing.Point(12, 42);
            this.cantactLabel.Name = "cantactLabel";
            this.cantactLabel.Size = new System.Drawing.Size(41, 12);
            this.cantactLabel.TabIndex = 4;
            this.cantactLabel.Text = "연락처";
            // 
            // kindOfCantactLabel
            // 
            this.kindOfCantactLabel.AutoSize = true;
            this.kindOfCantactLabel.Location = new System.Drawing.Point(12, 69);
            this.kindOfCantactLabel.Name = "kindOfCantactLabel";
            this.kindOfCantactLabel.Size = new System.Drawing.Size(69, 12);
            this.kindOfCantactLabel.TabIndex = 5;
            this.kindOfCantactLabel.Text = "연락처 종류";
            // 
            // nameEdit
            // 
            this.nameEdit.Image = ((System.Drawing.Image)(resources.GetObject("nameEdit.Image")));
            this.nameEdit.Location = new System.Drawing.Point(257, 10);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Size = new System.Drawing.Size(25, 25);
            this.nameEdit.TabIndex = 6;
            this.nameEdit.UseVisualStyleBackColor = true;
            this.nameEdit.Click += new System.EventHandler(this.nameEdit_Click);
            // 
            // cantactEdit
            // 
            this.cantactEdit.Image = ((System.Drawing.Image)(resources.GetObject("cantactEdit.Image")));
            this.cantactEdit.Location = new System.Drawing.Point(257, 36);
            this.cantactEdit.Name = "cantactEdit";
            this.cantactEdit.Size = new System.Drawing.Size(25, 25);
            this.cantactEdit.TabIndex = 7;
            this.cantactEdit.UseVisualStyleBackColor = true;
            this.cantactEdit.Click += new System.EventHandler(this.cantactEdit_Click);
            // 
            // kindOfCantactEdit
            // 
            this.kindOfCantactEdit.Image = ((System.Drawing.Image)(resources.GetObject("kindOfCantactEdit.Image")));
            this.kindOfCantactEdit.Location = new System.Drawing.Point(257, 63);
            this.kindOfCantactEdit.Name = "kindOfCantactEdit";
            this.kindOfCantactEdit.Size = new System.Drawing.Size(25, 25);
            this.kindOfCantactEdit.TabIndex = 8;
            this.kindOfCantactEdit.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(121, 116);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 71);
            this.exitButton.TabIndex = 9;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 201);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.kindOfCantactEdit);
            this.Controls.Add(this.cantactEdit);
            this.Controls.Add(this.nameEdit);
            this.Controls.Add(this.kindOfCantactLabel);
            this.Controls.Add(this.cantactLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.kindOfCantactTextBox);
            this.Controls.Add(this.cantactTextBox);
            this.Controls.Add(this.nameTextBox);
            this.MaximumSize = new System.Drawing.Size(351, 240);
            this.MinimumSize = new System.Drawing.Size(351, 240);
            this.Name = "EditingForm";
            this.Text = "EditingForm";
            this.Load += new System.EventHandler(this.EditingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cantactTextBox;
        private System.Windows.Forms.TextBox kindOfCantactTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label cantactLabel;
        private System.Windows.Forms.Label kindOfCantactLabel;
        private System.Windows.Forms.Button nameEdit;
        private System.Windows.Forms.Button cantactEdit;
        private System.Windows.Forms.Button kindOfCantactEdit;
        private System.Windows.Forms.Button exitButton;
    }
}