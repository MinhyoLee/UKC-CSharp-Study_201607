using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Housekeeping
{
    public partial class InputForm : Form
    {
        string iptMoney = string.Empty;
        string iptDate = string.Empty;
        string iptUseList = string.Empty;
        string iptCashCard = string.Empty;
        string iptAmount = string.Empty;
        string iptCustomer = string.Empty;

        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            InitInputData();
        }

        private void InitInputData()
        {
            if (rdbExport.Checked)
                iptMoney = "지출";
            else if (rdbImport.Checked)
                iptMoney = "수입";

            iptDate = dateTimePicker1.Text;

            iptUseList = cboUseList.SelectedText;

            if (rdbCash.Checked)
                iptCashCard = "현금";
            else if (rdbCard.Checked)
                iptCashCard = "카드";

            iptAmount = txtAmount.Text;
            iptCustomer = txtCustomer.Text;
        }

        #region MainForm에 전달할 변수 및 Data 저장
        public string IptMoney
        {
            get { return iptMoney; }
            set { iptMoney = value; }
        }
        public string IptDate
        {
            get { return iptDate; }
            set { iptDate = value; }
        }
        public string IptUseList
        {
            get { return iptUseList; }
            set { iptUseList = value; }
        }
        public string IptCashCard
        {
            get { return iptCashCard; }
            set { iptCashCard = value; }
        }
        public string IptAmount
        {
            get { return iptAmount; }
            set { iptAmount = value; }
        }
        public string IptCustomer
        {
            get { return iptCustomer; }
            set { iptCustomer = value; }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            HKPDB.AddData(iptDate, iptMoney, iptUseList, iptCashCard, iptAmount, iptCustomer);
            iptDate = "";
            iptMoney = "";
            iptUseList = "";
            iptCashCard = "";
            iptAmount = "";
            iptCustomer = "";

            dateTimePicker1.Text = "";
            cboUseList.SelectedText = "";


        }
    }
}

