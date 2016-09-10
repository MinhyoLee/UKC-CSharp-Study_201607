using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Housekeeping
{
    public partial class MainForm : Form
    {
        string iptMoney = string.Empty;
        string iptDate = string.Empty;
        string iptUseList = string.Empty;
        string iptCashCard = string.Empty;
        string iptAmount = string.Empty;
        string iptCustomer = string.Empty;
        private InputForm inputForm;
             
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void InitData()
        {
            listToday.Items.Clear();
            List<GetData> dataList;
            try
            {
                dataList = HKPDB.GetUseList();
                if (dataList.Count > 0)
                {
                    GetData data;
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        data = dataList[i];
                        listToday.Items.Add(data.Date.ToString());
                        listToday.Items[i].SubItems.Add(data.Debit);
                        listToday.Items[i].SubItems.Add(data.UseList);
                        listToday.Items[i].SubItems.Add(data.CashCard);
                        listToday.Items[i].SubItems.Add(data.Amount);
                        listToday.Items[i].SubItems.Add(data.Customer);
                    }
                }
                else { MessageBox.Show("Data가 없습니다."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }
        }

        private void showInputForm()
        {
            inputForm = new InputForm();
            if(inputForm.IsDisposed)
            {                
                inputForm.ShowDialog();
            }
            else
            {
                inputForm.Activate();
            }
        }
        
        private void closeInputForm()
        {
            if(!(inputForm == null))
            {
                inputForm.Close();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            showInputForm();
            if (inputForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iptMoney = inputForm.IptMoney;
                iptDate = inputForm.IptDate;
                iptUseList = inputForm.IptUseList;
                iptCashCard = inputForm.IptCashCard;
                iptAmount = inputForm.IptAmount;
                iptCustomer = inputForm.IptCustomer;
            }
            closeInputForm();

            InitData();
        }
    }
}