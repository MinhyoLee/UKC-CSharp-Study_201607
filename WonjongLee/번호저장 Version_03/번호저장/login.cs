using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 번호저장
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "sa"; // 아이디
            string pw = "1234";  // 비밀번호

            while (true)
            {
               if(textBox1.Text == id && textBox2.Text == pw)
                {

                    phone phone = new phone();
                    this.Visible = false;
                    phone.ShowDialog();
                    break;
                }
               else if (textBox1.Text != id && textBox2.Text != pw)
                {
                    MessageBox.Show("아이디와 비밀번호를 잘못 입력하셨습니다.");
                    textBox1.Focus(); // 아이디 입력하는 텍스트필드로 커서 이동
                    break;
                }

                else if (textBox1.Text != id)
                {
                    MessageBox.Show("아이디를 잘못 입력하셨습니다.");
                    textBox1.Focus(); // 아이디 입력하는 텍스트필드로 커서 이동
                    break;
                }

                else if (textBox2.Text != pw)
                {
                    MessageBox.Show("비밀 번호를 잘못 입력하셨습니다.");
                    textBox2.Focus(); // 비밀번호를 입력하는 텍스트필드로 커서 이동
                    break;
                }
            }// while문 끝
        }

    }
}
    
