using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_ver01
{
    public partial class Main_UI : Form
    {
        public Main_UI()
        {
            InitializeComponent();
        }

        private void standard_btn_Click(object sender, EventArgs e)
        {
            standard standard = new standard();
            standard.ShowDialog();
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            convert_cal convert_cal = new convert_cal();
            convert_cal.ShowDialog();
        }
    }
}
