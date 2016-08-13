using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  // DB를 사용하기 위해 추가 해주기!!
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // DB를 사용하기 위해 추가 해주기!!


namespace 번호저장
{
    public partial class phone : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=NumberList;Integrated Security=True"); // DB연동
        // 서버탐색기에서 해당 디비를 오른쪽 마우스 클릭 후 속성에 들어가서 연결 문자열 복사 해서 넣어주기!!
        public phone()
        {
            InitializeComponent();
        }

        private void phone_Load(object sender, EventArgs e)
        {
            /* 굳이 이렇게 포커스 설정을 안해도 설정에 들어가서
             * tabIndex로 순서를 정해주면 쉽게 설정 할 수 있다.
            this.ActiveControl = textBox2;
            textBox2.Focus();
            */

           Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();
            comboBox1.SelectedIndex = -1; // -1로 설정하지 않으면 
            // 콤보박스에 있는 글자가 사라지지 않고 다음 글자로 넘어감.

            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e) // insert 버튼 클릭시 동작하는 함수
        {
            con.Open(); // 디비 연결

            // 연결 문자열을 인자로 전달하여 SqlCommand 객채를 생성하고
            // 연결 문자열에 있는 데이터 소스 이름과 디비 이름 계정정보를 지정해줌. 즉 디비에 저장함.
            SqlCommand cmd = new SqlCommand(@"INSERT INTO NumberList (별명, 이름, 번호, 이메일, 분류) 
            VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "')", con);

            // ExecuteNonQuery함수는 insert(삽입), update(수정), delete(삭제)을 실행을 하도록 해주는 함수.
            cmd.ExecuteNonQuery();

            con.Close(); // 연결된 디비 닫음.

            MessageBox.Show("저장이 완료되었습니다."); // 저장이 되었으면 메시지 박스로 알려줌.

            Display(); // 지정된 데이터를 화면에 보여줌
        }

        void Display() // 저장된 데이터를 화면에 보여주는 함수 구현
        {
            // SqlDataAdapter는 디비로 부터 데이터 소스를 가져오게 해주는 객체
            SqlDataAdapter sda = new SqlDataAdapter("select * from NumberList", con); 

            DataTable dt = new DataTable(); // 데이터 테이블 개체 생성

            sda.Fill(dt); // Fill 함수를 이용해 생성된 데이터 테이블 소스의 데이터를 얻어옴.

            // dataGridView를 사용할 때 같은 행에 정보가 겹치지 않게 해주기 위해 클리어 해줌.
            dataGridView1.Rows.Clear();

            // 받아온 데이터 테이블을 foreach문으로 읽어옴.
            // DataTable은 DataRow로 구성되어 있기 때문에 반복문을 돌면서 데이터를 읽어옴.
            // 즉, 테이블에 속한 열의 정보를 가져옴.
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM NumberList 
            WHERE (번호 = '" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("삭제가 완료되었습니다.");

            Display();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE NumberList
SET    별명 = '" + textBox1.Text + "', 이름 = '" + textBox2.Text + "', 번호 = '" + textBox3.Text + "', 이메일 = '" + textBox4.Text + "', 분류 = '" + comboBox1.Text + "' WHERE (번호 = '" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("수정이 완료되었습니다.");

            Display();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from NumberList where (별명 like '%" + textBox5.Text + "%') or (번호 like '%" + textBox5.Text + "%')", con); //별명 또는 번호로 찾을 수 있음
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

        private void button5_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }
    }
}
