using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ukc_addrbook
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            lvAddress.Width = this.Width - 120;
            lvAddress.Height = this.Height - 80;
            lvAddress.Columns.Add("이름");
            lvAddress.Columns.Add("휴대폰");
            lvAddress.Columns.Add("회사");
            lvAddress.Columns.Add("회사전화");
            lvAddress.Columns.Add("회사팩스");
            ListViewItem lvi = new ListViewItem("Test");
            lvi.SubItems.Add("010-3333-3333");
            lvi.SubItems.Add("Test Company");
            lvi.SubItems.Add("02-3030-3030");
            lvi.SubItems.Add("02-3030-3040");
            lvAddress.Items.Add(lvi);
            lvAddress.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void main_form_SizeChanged(object sender, EventArgs e)
        {
            lvAddress.Width = this.Width - 120;
            lvAddress.Height = this.Height - 80;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit_form form = new edit_form();
            form.set_btnname("Add");
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int lvindex;
            String[] items = new String[5];
            edit_form form = new edit_form();
            form.set_btnname("Update");
            lvindex = lvAddress.FocusedItem.Index;
            items[0] = lvAddress.Items[lvindex].SubItems[0].Text;
            items[1] = lvAddress.Items[lvindex].SubItems[1].Text;
            items[2] = lvAddress.Items[lvindex].SubItems[2].Text;
            items[3] = lvAddress.Items[lvindex].SubItems[3].Text;
            items[4] = lvAddress.Items[lvindex].SubItems[4].Text;
            
            form.set_item(items[0], items[1], items[2], items[3], items[4]);

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("진심 지울거임?", "Confirm Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 

            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search_form form = new search_form();
            form.ShowDialog();
        }

        private void menu_about_Click(object sender, EventArgs e)
        {
            about_form form = new about_form();
            form.ShowDialog();
        }
    }
}
