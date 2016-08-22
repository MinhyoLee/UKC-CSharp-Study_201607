using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CantactManager
{
    public partial class mainForm : Form
    {
        DataManager cantact;
        public mainForm()
        {
            cantact = new DataManager();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(cantact.LoadCantact().ToArray());
        }

        private void deletItemButton_Click(object sender, EventArgs e)
        {

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            EditingForm editForm = new EditingForm();
            editForm.Show();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            EditingForm editForm = new EditingForm();
            editForm.Show();
        }

        private void searchingButton_Click(object sender, EventArgs e)
        {
            cantact.searchingName(listBox1, searchingTextBox.Text);
        }
    }
}
