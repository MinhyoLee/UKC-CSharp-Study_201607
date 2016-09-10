using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housekeeping
{
    public class GetData
    {
        private string date;
        private string debit;
        private string uselist;
        private string cashcard;
        private string amount;
        private string customer;
        

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Debit
        {
            get { return debit; }
            set { debit = value; }
        }
        public string UseList
        {
            get { return uselist; }
            set { uselist = value; }
        }
        public string CashCard
        {
            get { return cashcard; }
            set { cashcard = value; }
        }
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }
}