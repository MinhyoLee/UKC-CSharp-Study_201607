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

namespace 번호저장
{
    public partial class info : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=NumberList;Integrated Security=True"); // DB연동

        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open(); // 디비 연결

            SqlCommand cmd = new SqlCommand(@"INSERT INTO phone_info(이름, 번호, 주소) 
            VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox1.Text + "' )", con);
            
            cmd.ExecuteNonQuery();
            con.Close(); // 연결된 디비 닫음.

            MessageBox.Show("저장이 완료되었습니다.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from NumberList where (이름 like '%" + textBox2.Text + "%')", con); 
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["별명"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }

        void Display() // 저장된 데이터를 화면에 보여주는 함수 구현
        {
            // SqlDataAdapter는 디비로 부터 데이터 소스를 가져오게 해주는 객체
            SqlDataAdapter sda = new SqlDataAdapter("select * from NumberList", con);

            DataTable dt = new DataTable(); // 데이터 테이블 개체 생성

            sda.Fill(dt); // Fill 함수를 이용해 생성된 데이터 테이블 소스의 데이터를 얻어옴.

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["별명"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }

        void Display2() // 저장된 데이터를 화면에 보여주는 함수 구현
        {
            // SqlDataAdapter는 디비로 부터 데이터 소스를 가져오게 해주는 객체
            SqlDataAdapter sda = new SqlDataAdapter("select * from phone_info", con);

            DataTable dt = new DataTable(); // 데이터 테이블 개체 생성

            sda.Fill(dt); // Fill 함수를 이용해 생성된 데이터 테이블 소스의 데이터를 얻어옴.

            dataGridView2.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["이름"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
            }
        }

        private void info_Load(object sender, EventArgs e)
        {
            Display();
            Display2();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM phone_info 
            WHERE (번호 = '" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();

            Display2();

            MessageBox.Show("삭제가 완료되었습니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE phone_info
            SET    주소 = '" + textBox1.Text + "' WHERE (번호 = '" + textBox3.Text + "')", con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("수정이 완료되었습니다.");

            Display();
        }
    }
}
// //