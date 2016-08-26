using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ukc_addrbook
{
    public partial class edit_form : Form
    {
        public edit_form()
        {
            InitializeComponent();
        }

        public int set_btnname(String btnname)
        {
            btnOk.Text = btnname;
            return 0;
        }

        public int set_item(String name, String phone, String company, String companytel, String companyfax)
        {
            tbName.Text = name;
            tbPhone.Text = phone;
            tbCompany.Text = company;
            tbCompanyTel.Text = companytel;
            tbCompanyFax.Text = companyfax;
            return 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
