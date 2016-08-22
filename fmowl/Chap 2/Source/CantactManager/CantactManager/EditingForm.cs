using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantactManager
{
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void EditingForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Enabled = false;
            cantactTextBox.Enabled = false;
            kindOfCantactTextBox.Enabled = false;
        }

        private void cantactEdit_Click(object sender, EventArgs e)
        {

        }

        private void nameEdit_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
        }
    }
}
