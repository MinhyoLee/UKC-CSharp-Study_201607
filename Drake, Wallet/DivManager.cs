using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;

namespace e_wallet
{
	/// <summary>
	/// DivManager에 대한 요약 설명입니다.
	/// </summary>
	public class DivManager : Config
	{
		private DataSet myDs;
		private OleDbDataAdapter myDa;
		private OleDbConnection myConn;

		private double sumMoney;

		private System.Windows.Forms.ColumnHeader ColumnHeader11;
		private System.Windows.Forms.ColumnHeader ColumnHeader12;
		private System.Windows.Forms.ColumnHeader ColumnHeader13;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvDivList;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUpMoney;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DivManager()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.lvDivList = new System.Windows.Forms.ListView();
			this.ColumnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUpMoney = new System.Windows.Forms.TextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblName = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvDivList
			// 
			this.lvDivList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvDivList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.ColumnHeader11,
																						this.ColumnHeader12,
																						this.ColumnHeader13});
			this.lvDivList.FullRowSelect = true;
			this.lvDivList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvDivList.Location = new System.Drawing.Point(16, 24);
			this.lvDivList.MultiSelect = false;
			this.lvDivList.Name = "lvDivList";
			this.lvDivList.Size = new System.Drawing.Size(168, 128);
			this.lvDivList.TabIndex = 6;
			this.lvDivList.View = System.Windows.Forms.View.Details;
			this.lvDivList.SelectedIndexChanged += new System.EventHandler(this.lvDivList_SelectedIndexChanged);
			// 
			// ColumnHeader11
			// 
			this.ColumnHeader11.Text = "Seq";
			this.ColumnHeader11.Width = 0;
			// 
			// ColumnHeader12
			// 
			this.ColumnHeader12.Text = "구    분";
			this.ColumnHeader12.Width = 75;
			// 
			// ColumnHeader13
			// 
			this.ColumnHeader13.Text = "잔    고";
			this.ColumnHeader13.Width = 93;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 11;
			this.label4.Text = "대상 추가";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(72, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(88, 21);
			this.txtName.TabIndex = 10;
			this.txtName.Text = "";
			// 
			// txtUpMoney
			// 
			this.txtUpMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUpMoney.Location = new System.Drawing.Point(72, 48);
			this.txtUpMoney.Name = "txtUpMoney";
			this.txtUpMoney.Size = new System.Drawing.Size(88, 21);
			this.txtUpMoney.TabIndex = 14;
			this.txtUpMoney.Text = "";
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(168, 24);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(40, 23);
			this.btnInsert.TabIndex = 15;
			this.btnInsert.Text = "추가";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "구       분";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "잔       고";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(168, 48);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(40, 23);
			this.btnUpdate.TabIndex = 19;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTotal);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.lvDivList);
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 184);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "금전 관리";
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblTotal.ForeColor = System.Drawing.Color.Red;
			this.lblTotal.Location = new System.Drawing.Point(64, 160);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(120, 16);
			this.lblTotal.TabIndex = 19;
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 16);
			this.label13.TabIndex = 18;
			this.label13.Text = "Total";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblName);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtUpMoney);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Location = new System.Drawing.Point(224, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 80);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "수정";
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblName.Location = new System.Drawing.Point(72, 24);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(88, 23);
			this.lblName.TabIndex = 20;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtName);
			this.groupBox3.Controls.Add(this.btnInsert);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(224, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(216, 56);
			this.groupBox3.TabIndex = 22;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "추가";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnDel);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(224, 152);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(216, 48);
			this.groupBox4.TabIndex = 23;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "삭제";
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(168, 16);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(40, 23);
			this.btnDel.TabIndex = 18;
			this.btnDel.Text = "삭제";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "선택한 대상이 삭제 됩니다.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DivManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(448, 213);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DivManager";
			this.Text = "DivManager";
			this.Load += new System.EventHandler(this.DivManager_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void DivManager_Load(object sender, System.EventArgs e)
		{
			ListLoad();
		}

		// 리스트 로딩
		private void ListLoad()
		{
			sumMoney = 0;

			myConn = new OleDbConnection (connString);
			string [] tmp = new string[3];

			try
			{
				myConn = new OleDbConnection (connString);

				string queryString = "SELECT seq, div, currMoney FROM DivMoney";
				myDa = new OleDbDataAdapter(queryString, myConn);

				myDs = new DataSet();
			
				myDa.Fill (myDs,"DB");

				for( int i=0; i< myDs.Tables["DB"].Rows.Count; i++)
				{
					sumMoney += Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[2].ToString().Trim());

					tmp[0] = myDs.Tables["DB"].Rows[i].ItemArray[0].ToString().Trim();
					tmp[1] = myDs.Tables["DB"].Rows[i].ItemArray[1].ToString().Trim();
					tmp[2] = String.Format("\\{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[2].ToString().Trim()));

					ListViewItem lvItem = new ListViewItem(tmp, 0);
					lvDivList.Items.Add(lvItem);
				}

				lblTotal.Text = String.Format("\\{0:#,###}",sumMoney);
			}
			catch(Exception e1)
			{
				MessageBox.Show(e1.Message);
			}
			finally
			{
				myConn.Close();
			}
		}

		private void lvDivList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			foreach ( ListViewItem list in lvDivList.Items )
			{					
				if( list.Selected )
				{	
					lblName.Text = list.SubItems[1].Text.ToString();
					txtUpMoney.Text = (list.SubItems[2].Text.Replace("\\","")).Replace(",","").ToString();
				}
			}
		}

		private void btnInsert_Click(object sender, System.EventArgs e)
		{
			myConn = new OleDbConnection (connString);
			OleDbCommand myCmd = new OleDbCommand("", myConn);
			try
			{
				////////// DivMoney 로그 추가

				string queryString =
					String.Format ("INSERT INTO DivMoney(div, currMoney) VALUES ('{0}','{1}')", txtName.Text, "0");

				myConn.Open();
				myCmd.CommandText = queryString;
				myCmd.ExecuteNonQuery();					
			}
			catch(Exception)
			{
			}
			finally
			{
				myConn.Close();
				lvDivList.Items.Clear();
				ListLoad();
				txtName.Text = "";
			}
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{

			string seq="";
			foreach ( ListViewItem list in lvDivList.Items )
			{					
				if( list.Selected )
				{	
					seq = list.SubItems[0].Text.ToString();
				}
			}

			string message = "확인을 누르시면 삭제 됩니다.";
			string caption = "선택하신 대상이 삭제 됩니다.";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result=DialogResult.No;
			
			if(seq != "")
				result = MessageBox.Show(this, message, caption, buttons);
			else
				MessageBox.Show("삭제할 리스트를 선택하세요!!");

			if(result == DialogResult.Yes)
			{
				myConn = new OleDbConnection (connString);
				OleDbCommand myCmd = new OleDbCommand("", myConn);
				try
				{
					////////// DivMoney 삭제

					string queryString =
						String.Format ("DELETE FROM DivMoney WHERE seq = {0}", seq);

					myConn.Open();
					myCmd.CommandText = queryString;
					myCmd.ExecuteNonQuery();			
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					myConn.Close();
					lvDivList.Items.Clear();
					ListLoad();
					lblName.Text = "";
					txtUpMoney.Text ="";
				}		
			}
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			string seq="";
			foreach ( ListViewItem list in lvDivList.Items )
			{					
				if( list.Selected )
				{	
					seq = list.SubItems[0].Text.ToString();
				}
			}

			myConn = new OleDbConnection (connString);
			OleDbCommand myCmd = new OleDbCommand("", myConn);
			try
			{
				////////// DivMoney 업데이트

				string queryString = "UPDATE DivMoney SET currMoney='"+ txtUpMoney.Text +"' WHERE seq="+ seq + ";";
				myCmd.CommandText = queryString;
				myConn.Open();	
				myCmd.ExecuteNonQuery();
			}
			catch(Exception)
			{
				MessageBox.Show("수정할 리스트를 선택하세요!!");
			}
			finally
			{
				myConn.Close();
				txtUpMoney.Text = "";
				lvDivList.Items.Clear();				
				ListLoad();
			}
		}
	}
}
