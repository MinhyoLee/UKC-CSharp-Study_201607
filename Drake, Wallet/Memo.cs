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
	/// Memo에 대한 요약 설명입니다.
	/// </summary>
	public class Memo : Config
	{
		private OleDbConnection myConn;
		private DataSet myDs;
		private OleDbDataAdapter myDa;
		private OleDbCommand myCmd;

		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader ColumnHeader11;
		private System.Windows.Forms.ColumnHeader ColumnHeader12;
		private System.Windows.Forms.ColumnHeader ColumnHeader13;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ListView lvMemo;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbDay;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Memo()
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
			this.txtContent = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.lvMemo = new System.Windows.Forms.ListView();
			this.ColumnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbDay = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// txtContent
			// 
			this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContent.Location = new System.Drawing.Point(80, 64);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(320, 32);
			this.txtContent.TabIndex = 23;
			this.txtContent.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 32);
			this.label5.TabIndex = 24;
			this.label5.Text = "메       모";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(176, 8);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 24);
			this.btnSave.TabIndex = 25;
			this.btnSave.Text = "추가";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lvMemo
			// 
			this.lvMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvMemo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.ColumnHeader13,
																					 this.ColumnHeader11,
																					 this.ColumnHeader12});
			this.lvMemo.FullRowSelect = true;
			this.lvMemo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMemo.Location = new System.Drawing.Point(8, 104);
			this.lvMemo.MultiSelect = false;
			this.lvMemo.Name = "lvMemo";
			this.lvMemo.Size = new System.Drawing.Size(392, 216);
			this.lvMemo.TabIndex = 26;
			this.lvMemo.View = System.Windows.Forms.View.Details;
			this.lvMemo.SelectedIndexChanged += new System.EventHandler(this.lvMemo_SelectedIndexChanged);
			// 
			// ColumnHeader13
			// 
			this.ColumnHeader13.Text = "No";
			this.ColumnHeader13.Width = 28;
			// 
			// ColumnHeader11
			// 
			this.ColumnHeader11.Text = "날짜";
			this.ColumnHeader11.Width = 78;
			// 
			// ColumnHeader12
			// 
			this.ColumnHeader12.Text = "내용";
			this.ColumnHeader12.Width = 285;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(232, 8);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(56, 24);
			this.btnUpdate.TabIndex = 29;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(288, 8);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(56, 24);
			this.btnDel.TabIndex = 30;
			this.btnDel.Text = "지우기";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(344, 8);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 24);
			this.btnClose.TabIndex = 31;
			this.btnClose.Text = "닫기";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(272, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 23);
			this.label3.TabIndex = 43;
			this.label3.Text = "일";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(208, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 23);
			this.label8.TabIndex = 42;
			this.label8.Text = "월";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbDay
			// 
			this.cbDay.Items.AddRange(new object[] {
													   "01",
													   "02",
													   "03",
													   "04",
													   "05",
													   "06",
													   "07",
													   "08",
													   "09",
													   "10",
													   "11",
													   "12",
													   "13",
													   "14",
													   "15",
													   "16",
													   "17",
													   "18",
													   "19",
													   "20",
													   "21",
													   "22",
													   "23",
													   "24",
													   "25",
													   "26",
													   "27",
													   "28",
													   "29",
													   "30",
													   "31"});
			this.cbDay.Location = new System.Drawing.Point(224, 40);
			this.cbDay.Name = "cbDay";
			this.cbDay.Size = new System.Drawing.Size(48, 20);
			this.cbDay.TabIndex = 41;
			this.cbDay.Text = "일";
			// 
			// cbMonth
			// 
			this.cbMonth.Items.AddRange(new object[] {
														 "01",
														 "02",
														 "03",
														 "04",
														 "05",
														 "06",
														 "07",
														 "08",
														 "09",
														 "10",
														 "11",
														 "12"});
			this.cbMonth.Location = new System.Drawing.Point(160, 40);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(48, 20);
			this.cbMonth.TabIndex = 39;
			this.cbMonth.Text = "월";
			// 
			// cbYear
			// 
			this.cbYear.Items.AddRange(new object[] {
														"2004",
														"2005",
														"2006",
														"2007",
														"2008",
														"2009",
														"2010",
														"2011",
														"2012",
														"2013",
														"2014",
														"2015",
														"2016",
														"2017",
														"2018",
														"2019",
														"2020"});
			this.cbYear.Location = new System.Drawing.Point(80, 40);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(64, 20);
			this.cbYear.TabIndex = 38;
			this.cbYear.Text = "년";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(144, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 23);
			this.label10.TabIndex = 40;
			this.label10.Text = "년";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 37;
			this.label4.Text = "메모 일자";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 32);
			this.label1.TabIndex = 44;
			this.label1.Text = "메  모  관  리";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(360, 320);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(45, 17);
			this.linkLabel1.TabIndex = 45;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "History";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Memo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(408, 331);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbDay);
			this.Controls.Add(this.cbMonth);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lvMemo);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Memo";
			this.Text = "Memo";
			this.Load += new System.EventHandler(this.Memo_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Memo_Load(object sender, System.EventArgs e)
		{
			MemoLoad();
		}

		private void MemoLoad()
		{
			string currdate="";
			currdate = DateTime.Now.ToShortDateString().ToString();//.Replace("-","");
			cbYear.Text = currdate.Substring(0,4);
			cbMonth.Text = currdate.Substring(5,2);
			cbDay.Text = currdate.Substring(8,2);	

			myConn = new OleDbConnection(connString);
			
			string query = "SELECT * FROM MemoMoney WHERE div = 0";
			string[] tmp = new string[3];
			try
			{
				myDa = new OleDbDataAdapter(query, myConn);
				myDs = new DataSet();
				myDa.Fill(myDs, "DB");

				for(int i=0; i< myDs.Tables["DB"].Rows.Count; i++)
				{
					tmp[0] = myDs.Tables["DB"].Rows[i].ItemArray[0].ToString();
					tmp[1] = myDs.Tables["DB"].Rows[i].ItemArray[1].ToString();
					tmp[2] = myDs.Tables["DB"].Rows[i].ItemArray[2].ToString();
					ListViewItem lvItem = new ListViewItem(tmp,0);
					lvMemo.Items.Add(lvItem);
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(txtContent.Text == "")
			{
				MessageBox.Show("메모 내용을 입력하세요.");
			}
			else
			{

				string uniDate = "";
				uniDate = cbYear.Text +"-"+ cbMonth.Text +"-"+ cbDay.Text;

				myConn = new OleDbConnection (connString);
				myCmd = new OleDbCommand("", myConn);
						
				try
				{
					string queryString = String.Format ("INSERT INTO MemoMoney(logDate, content, div) VALUES ('{0}','{1}',{2})", uniDate, txtContent.Text, "0");

					myConn.Open();
					myCmd.CommandText = queryString;
					myCmd.ExecuteNonQuery();						

				}
				catch(Exception ex2)
				{
					MessageBox.Show(ex2.Message);
				}
				finally	
				{
					myConn.Close();
					lvMemo.Items.Clear();
					MemoLoad();
				}
				txtContent.Text ="";
			}
		}

		private void lvMemo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			foreach ( ListViewItem list in lvMemo.Items )
			{					
				if( list.Selected )
				{	
					string currdate = list.SubItems[1].Text.ToString();
					cbYear.Text = currdate.Substring(0,4);
					cbMonth.Text = currdate.Substring(5,2);
					cbDay.Text = currdate.Substring(8,2);	
					
					txtContent.Text = list.SubItems[2].Text.ToString();
				}
			}
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			string seq="";
			foreach ( ListViewItem list in lvMemo.Items )
			{					
				if( list.Selected )
				{	
					seq = list.SubItems[0].Text.ToString();
				}
			}

			string message = "확인을 누르시면 수정 됩니다.";
			string caption = "선택하신 대상이 수정 됩니다.";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result=DialogResult.No;
			
			if(seq != "")
				result = MessageBox.Show(this, message, caption, buttons);
			else
				MessageBox.Show("수정할 리스트를 선택하세요!!");

			if(result == DialogResult.Yes)
			{
				myConn = new OleDbConnection(connString);
				myCmd = new OleDbCommand("", myConn);

				string uniDate = "";
				uniDate = cbYear.Text +"-"+ cbMonth.Text +"-"+ cbDay.Text;

				try
				{
						myConn.Open();

					string query = "UPDATE MemoMoney SET content = '"+txtContent.Text+"', logDate = '"+ uniDate +"' WHERE seq ="+seq;
					myCmd.CommandText=query;

					myCmd.ExecuteNonQuery();
				}
				catch(Exception ex3)
				{
					MessageBox.Show(ex3.Message);
				}
				finally
				{
					myConn.Close();
					lvMemo.Items.Clear();
					MemoLoad();
				}
				txtContent.Text = "";
			}
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{		
			string seq="";
			foreach ( ListViewItem list in lvMemo.Items )
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
				myConn = new OleDbConnection(connString);
				myCmd = new OleDbCommand("", myConn);

				string uniDate = "";
				uniDate = cbYear.Text +"-"+ cbMonth.Text +"-"+ cbDay.Text;

				try
				{
					if(linkLabel1.Text == "List")
					{
						myConn.Open();

						string query = "DELETE FROM MemoMoney WHERE seq ="+seq;
						myCmd.CommandText=query;

						myCmd.ExecuteNonQuery();
					}
					else
					{
						myConn.Open();

						string query = "UPDATE MemoMoney SET div = 1 WHERE seq ="+seq;
						myCmd.CommandText=query;

						myCmd.ExecuteNonQuery();
					}
				}
				catch(Exception ex3)
				{
					MessageBox.Show(ex3.Message);
				}
				finally
				{
					myConn.Close();
					lvMemo.Items.Clear();
					MemoLoad();
					txtContent.Text="";
				}
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lvMemo.Items.Clear();
			string query = "SELECT * FROM MemoMoney WHERE div NOT IN(0)";

			if(linkLabel1.Text != "History")
			{
				query = "SELECT * FROM MemoMoney WHERE div = 0";
				linkLabel1.Text = "History";
				btnDel.Text = "지우기";
			}
			else
			{
				linkLabel1.Text = "List";
				btnDel.Text = "삭제";
			}

			string currdate="";
			currdate = DateTime.Now.ToShortDateString().ToString();//.Replace("-","");
			cbYear.Text = currdate.Substring(0,4);
			cbMonth.Text = currdate.Substring(5,2);
			cbDay.Text = currdate.Substring(8,2);	

			myConn = new OleDbConnection(connString);
			
			string[] tmp = new string[3];
			try
			{
				myDa = new OleDbDataAdapter(query, myConn);
				myDs = new DataSet();
				myDa.Fill(myDs, "DB");

				for(int i=0; i< myDs.Tables["DB"].Rows.Count; i++)
				{
					tmp[0] = myDs.Tables["DB"].Rows[i].ItemArray[0].ToString();
					tmp[1] = myDs.Tables["DB"].Rows[i].ItemArray[1].ToString();
					tmp[2] = myDs.Tables["DB"].Rows[i].ItemArray[2].ToString();
					ListViewItem lvItem = new ListViewItem(tmp,0);
					lvMemo.Items.Add(lvItem);
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
