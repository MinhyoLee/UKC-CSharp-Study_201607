using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calculator_ver01
{
    public partial class convert_cal : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Calculator; Integrated Security = True");

        int x, p, decimal1, len;
        char[] str = new char[20];
        int [] result = new int [20];
        char[] output = new char[16] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                      'A', 'B', 'C','D','E','F'};

        public convert_cal()
        {
            InitializeComponent();
        }

        int xtoten(int x, char[] str)
        {
            int decimal1 = 0;

            for (int i = str.Length-1; i>=0; i--)
            {
                decimal1 = decimal1 + (str[i] - '0') * (int)Math.Pow(x, str.Length - i - 1);
            }

            resultValue.Text = decimal1.ToString();

            return decimal1;
        }

        int tentop(int p, int decimal1, int[] result)
        {
            int len = 0;
            for(len = 0; len < decimal1; len++)
            {
                result[len] = decimal1 % p;
                decimal1 = decimal1 / p;
            }
            resultValue.Text = decimal1.ToString();

            return len - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open(); // 디비 연결

            x = int.Parse(textBox1.Text);
            str = (textBox3.Text).ToCharArray();

            decimal1 = xtoten(x, str);

            p = int.Parse(textBox2.Text);

            len = tentop(p, decimal1, result);

            for(int i = len; i>= 0; i--)
            {
                resultValue.Text = output[result[i]].ToString();
            }

            SqlCommand cmd = new SqlCommand(@"INSERT INTO convert_cal (값) 
            VALUES ('" + resultValue.Text + "' )", con);

            // ExecuteNonQuery함수는 insert(삽입), update(수정), delete(삭제)을 실행을 하도록 해주는 함수.
            cmd.ExecuteNonQuery();

            con.Close(); // 연결된 디비 닫음.
        }
    }
}
