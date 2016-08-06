using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // DB를 사용하기 위해 추가 해주기!!

namespace Calculator_ver01
{
    // public enum operators { add, sub, multi, div };

    public partial class standard : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Calculator; Integrated Security = True");

        double resultValue = 0;
        string operation = "";
        public bool isOperation = false;  

        public standard()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Results_Window.Text == "0") || isOperation)
                Results_Window.Clear();

            isOperation = false;
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if(!Results_Window.Text.Contains("."))
                    Results_Window.Text = Results_Window.Text + btn.Text;
            }
            else
            {
                Results_Window.Text = Results_Window.Text + btn.Text;
            }

           

            //if (Results_Window.Text == "0")
            //    Results_Window.Text = btn.Text;
            //else
            //    Results_Window.Text = Results_Window.Text + btn.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultValue != 0)
            {
                button11.PerformClick(); // PerformClick() 클릭이벤트를 강제로 실행시킴
                operation = btn.Text;
                label1.Text = resultValue + " " + operation;
                isOperation = true;
            }
            else
            {
                operation = btn.Text;
                resultValue = double.Parse(Results_Window.Text);
                label1.Text = resultValue + " " + operation;
                isOperation = true;
            }
        }

        private void clear(object sender, EventArgs e)
        {
            Results_Window.Clear();
            label1.Text = "";
            Results_Window.Text = "0";
            resultValue = 0;
        }

        private void equal(object sender, EventArgs e)
        {
            con.Open(); // 디비 연결

            switch (operation)
            {
                case "+":
                    Results_Window.Text = (resultValue + double.Parse(Results_Window.Text)).ToString();
                    break;

                case "-":
                    Results_Window.Text = (resultValue - double.Parse(Results_Window.Text)).ToString();
                    break;

                case "*":
                    Results_Window.Text = (resultValue * double.Parse(Results_Window.Text)).ToString();
                    break;

                case "/":
                    Results_Window.Text = (resultValue / double.Parse(Results_Window.Text)).ToString();
                    break;

                default:
                    break;
            }

            resultValue = double.Parse(Results_Window.Text);
            label1.Text = "";

            SqlCommand cmd = new SqlCommand(@"INSERT INTO Calculator_cal (값) 
            VALUES ('" + Results_Window.Text + "' )", con);

            // ExecuteNonQuery함수는 insert(삽입), update(수정), delete(삭제)을 실행을 하도록 해주는 함수.
            cmd.ExecuteNonQuery();

            con.Close(); // 연결된 디비 닫음.
        }

        private void back_Click(object sender, EventArgs e)
        {
            Results_Window.Text = Results_Window.Text.Substring(0, Results_Window.Text.Length - 1);
        }
    }
}
