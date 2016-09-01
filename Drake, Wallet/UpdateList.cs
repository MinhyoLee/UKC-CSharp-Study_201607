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
	/// UpdateList에 대한 요약 설명입니다.
	/// </summary>
	public class UpdateList : Config
	{
		private OleDbConnection myConn;

		private string seq;

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbDay;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtContent;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UpdateList()
		{
			InitializeComponent();
		}

		public UpdateList(string seq, string logdate, string content)
		{
			InitializeComponent();

			this.seq = seq;

			cbYear.Text = logdate.Substring(0,4);
			cbMonth.Text = logdate.Substring(5,2);
			cbDay.Text = logdate.Substring(8,2);	

			txtContent.Text = content;
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbDay = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(120, 56);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "수정";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(200, 56);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.TabIndex = 1;
			this.btnCancle.Text = "취소";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(264, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 23);
			this.label5.TabIndex = 29;
			this.label5.Text = "일";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(200, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "월";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.cbDay.Location = new System.Drawing.Point(216, 8);
			this.cbDay.Name = "cbDay";
			this.cbDay.Size = new System.Drawing.Size(48, 20);
			this.cbDay.TabIndex = 26;
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
			this.cbMonth.Location = new System.Drawing.Point(152, 8);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(48, 20);
			this.cbMonth.TabIndex = 24;
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
			this.cbYear.Location = new System.Drawing.Point(72, 8);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(64, 20);
			this.cbYear.TabIndex = 23;
			this.cbYear.Text = "년";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "날      짜";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(136, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 23);
			this.label2.TabIndex = 25;
			this.label2.Text = "년";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 30;
			this.label1.Text = "내      용";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtContent
			// 
			this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContent.Location = new System.Drawing.Point(72, 32);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(200, 21);
			this.txtContent.TabIndex = 31;
			this.txtContent.Text = "";
			// 
			// UpdateList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(282, 83);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbDay);
			this.Controls.Add(this.cbMonth);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UpdateList";
			this.Text = "UpdateList";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			string uniDate = "";
			uniDate = cbYear.Text +"-"+ cbMonth.Text +"-"+ cbDay.Text;
			myConn = new OleDbConnection (connString);
			OleDbCommand myCmd = new OleDbCommand("", myConn);

			try
			{
				////////// LogMoney 업데이트

				string queryString = "UPDATE LogMoney SET logdate='"+ uniDate +"', content = '"+txtContent.Text+"' WHERE seq="+ seq + ";";
				myCmd.CommandText = queryString;
				myConn.Open();	
				myCmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				myConn.Close();
				this.Close();
			}

		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
