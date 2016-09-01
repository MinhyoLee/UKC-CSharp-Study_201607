using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace e_wallet
{
	/// <summary>
	/// Wallet에 대한 요약 설명입니다.
	/// </summary>
	public class Wallet : Config
	{
		private DataSet myDs;
		private OleDbDataAdapter myDa;
		private OleDbConnection myConn;
		private OleDbCommand myCmd;

		private double sumMoney;

		private System.Windows.Forms.ListView lvDiv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvLast;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.ComboBox cbDiv;
		private System.Windows.Forms.ComboBox cbInOut;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader ColumnHeader11;
		private System.Windows.Forms.ColumnHeader ColumnHeader12;
		private System.Windows.Forms.ColumnHeader ColumnHeader13;
		private System.Windows.Forms.ColumnHeader ColumnHeader14;
		private System.Windows.Forms.ColumnHeader ColumnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbDay;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDivManager;
		private System.Windows.Forms.Button btnListView;
		private System.Windows.Forms.Button btnMemo;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Wallet()
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

		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Wallet());
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.lvDiv = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLast = new System.Windows.Forms.ListView();
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDiv = new System.Windows.Forms.ComboBox();
            this.cbInOut = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDivManager = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnMemo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDiv
            // 
            this.lvDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvDiv.FullRowSelect = true;
            this.lvDiv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDiv.Location = new System.Drawing.Point(16, 24);
            this.lvDiv.MultiSelect = false;
            this.lvDiv.Name = "lvDiv";
            this.lvDiv.Size = new System.Drawing.Size(152, 88);
            this.lvDiv.TabIndex = 0;
            this.lvDiv.UseCompatibleStateImageBehavior = false;
            this.lvDiv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "구분";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "잔금";
            this.columnHeader3.Width = 89;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "총 금액  :";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.ForeColor = System.Drawing.Color.Navy;
            this.lblTotal.Location = new System.Drawing.Point(80, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 16);
            this.lblTotal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "최근 내역";
            // 
            // lvLast
            // 
            this.lvLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader11,
            this.ColumnHeader12,
            this.ColumnHeader13,
            this.ColumnHeader14,
            this.ColumnHeader15,
            this.columnHeader16});
            this.lvLast.FullRowSelect = true;
            this.lvLast.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLast.Location = new System.Drawing.Point(176, 24);
            this.lvLast.MultiSelect = false;
            this.lvLast.Name = "lvLast";
            this.lvLast.Size = new System.Drawing.Size(392, 88);
            this.lvLast.TabIndex = 4;
            this.lvLast.UseCompatibleStateImageBehavior = false;
            this.lvLast.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "날짜";
            this.ColumnHeader11.Width = 46;
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.Text = "내용";
            this.ColumnHeader12.Width = 71;
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = "수입";
            this.ColumnHeader13.Width = 57;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = "지출";
            this.ColumnHeader14.Width = 56;
            // 
            // ColumnHeader15
            // 
            this.ColumnHeader15.Text = "잔고";
            this.ColumnHeader15.Width = 89;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "구분";
            this.columnHeader16.Width = 72;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "해당 일자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "내       용";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.Location = new System.Drawing.Point(88, 48);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(192, 21);
            this.txtContent.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 72);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "금       액";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoney
            // 
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(88, 72);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(144, 21);
            this.txtMoney.TabIndex = 2;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "종       류";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDiv
            // 
            this.cbDiv.DisplayMember = "div";
            this.cbDiv.Location = new System.Drawing.Point(88, 96);
            this.cbDiv.Name = "cbDiv";
            this.cbDiv.Size = new System.Drawing.Size(72, 20);
            this.cbDiv.TabIndex = 15;
            this.cbDiv.ValueMember = "seq";
            // 
            // cbInOut
            // 
            this.cbInOut.Items.AddRange(new object[] {
            "지출",
            "수입"});
            this.cbInOut.Location = new System.Drawing.Point(176, 96);
            this.cbInOut.Name = "cbInOut";
            this.cbInOut.Size = new System.Drawing.Size(56, 20);
            this.cbInOut.TabIndex = 17;
            this.cbInOut.Text = "지출";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbDay);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.cbDiv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbInOut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입.출금 내역 입력";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(336, 80);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(64, 32);
            this.btnCancle.TabIndex = 37;
            this.btnCancle.Text = "취소";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(280, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "일";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(216, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 35;
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
            this.cbDay.Location = new System.Drawing.Point(232, 24);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(48, 20);
            this.cbDay.TabIndex = 34;
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
            this.cbMonth.Location = new System.Drawing.Point(168, 24);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(48, 20);
            this.cbMonth.TabIndex = 32;
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
            this.cbYear.Location = new System.Drawing.Point(88, 24);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(64, 20);
            this.cbYear.TabIndex = 31;
            this.cbYear.Text = "년";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(152, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "년";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(264, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(64, 32);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "입력";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(336, 32);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(64, 24);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "계산기";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 24);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "종    료";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDivManager
            // 
            this.btnDivManager.Location = new System.Drawing.Point(448, 165);
            this.btnDivManager.Name = "btnDivManager";
            this.btnDivManager.Size = new System.Drawing.Size(120, 24);
            this.btnDivManager.TabIndex = 39;
            this.btnDivManager.Text = "금전 관리";
            this.btnDivManager.Click += new System.EventHandler(this.btnDivManager_Click);
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(448, 135);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(120, 24);
            this.btnListView.TabIndex = 38;
            this.btnListView.Text = "상세 내역 보기";
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnMemo
            // 
            this.btnMemo.Location = new System.Drawing.Point(448, 195);
            this.btnMemo.Name = "btnMemo";
            this.btnMemo.Size = new System.Drawing.Size(120, 23);
            this.btnMemo.TabIndex = 42;
            this.btnMemo.Text = "메모 관리";
            this.btnMemo.Click += new System.EventHandler(this.btnMemo_Click);
            // 
            // Wallet
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(584, 259);
            this.Controls.Add(this.btnMemo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDiv);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.btnDivManager);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Wallet_Load(object sender, System.EventArgs e)
		{
			string currdate="";
			currdate = DateTime.Now.ToShortDateString().ToString();//.Replace("-","");
			cbYear.Text = currdate.Substring(0,4);
			cbMonth.Text = currdate.Substring(5,2);
			cbDay.Text = currdate.Substring(8,2);	

			DivLoad();
			LastLoad();
			CbDivLoad();
		}

		private int SortProcess()
		{
			myConn = new System.Data.OleDb.OleDbConnection(connString);
			myCmd = new OleDbCommand("", myConn);

			string uniDate = "";
			uniDate = cbYear.Text +"-"+ cbMonth.Text +"-"+ cbDay.Text;

			string query = "SELECT seq,inMoney,outMoney,currMoney FROM LogMoney WHERE logDate > '"+ uniDate + "' Order By logDate Asc ,seq ASC";

			myDa = new System.Data.OleDb.OleDbDataAdapter(query, myConn);

			myDs = new DataSet();

			myDa.Fill(myDs, "DB");
			if(myDs.Tables["DB"].Rows.Count != 0)
			{
				string[] seq		= new string[myDs.Tables["DB"].Rows.Count];
				double[] inMoney	= new double[myDs.Tables["DB"].Rows.Count];
				double[] outMoney	= new double[myDs.Tables["DB"].Rows.Count];
				double[] currMoney	= new double[myDs.Tables["DB"].Rows.Count];

				for(int i = 0; i < myDs.Tables["DB"].Rows.Count; i++)
				{
					seq[i] = myDs.Tables["DB"].Rows[i].ItemArray[0].ToString();
					inMoney[i] = Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[1].ToString());
					outMoney[i] = Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[2].ToString());
					currMoney[i] = Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[3].ToString());
				}
			
				////////// LogMoney 로그 추가
				string moneyIn="0", moneyOut="0";
				double preMoney = 0;
				
				if(cbInOut.SelectedIndex == 1)
				{
					preMoney = ((currMoney[0]+outMoney[0])-inMoney[0])+Double.Parse(txtMoney.Text);
					moneyIn = txtMoney.Text;
				}
				else
				{
					preMoney = ((currMoney[0]+outMoney[0])-inMoney[0])-Double.Parse(txtMoney.Text);
					moneyOut = txtMoney.Text;
				}

				try
				{

					int chk = 0;
					for(int j = 0; j < myDs.Tables["DB"].Rows.Count; j++)
					{
						if(j == 0)
							currMoney[j] = (preMoney+inMoney[j])-outMoney[j];
						else
							currMoney[j] = (currMoney[j-1]+inMoney[j])-outMoney[j];

						if(currMoney[j] < 0)
							chk=1;
					}

					if(chk == 0)
					{
						myConn.Open();
						myCmd.Transaction = myConn.BeginTransaction();// 트랜잭션시작
						for(int l = 0; l < myDs.Tables["DB"].Rows.Count; l++)
						{
							myCmd.CommandText = "Update LogMoney Set currMoney = '"+ currMoney[l].ToString() +"' WHERE seq="+seq[l];
							myCmd.ExecuteNonQuery();
						}

						string queryString =
							String.Format ("INSERT INTO LogMoney(logDate, content, inMoney, outMoney, currMoney, div) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", uniDate, txtContent.Text, moneyIn, moneyOut, preMoney, cbDiv.Text);
						myCmd.CommandText = queryString;
						myCmd.ExecuteNonQuery();

						////////// DivMoney 업데이트
						string currMoneyup = (lvDiv.Items[cbDiv.SelectedIndex].SubItems[1].Text.Replace("\\","")).Replace(",","");
						if(currMoneyup == "")
							currMoneyup = "0";
				
						if(cbInOut.SelectedIndex == 1)
							currMoneyup = (Double.Parse(currMoneyup) + Double.Parse(txtMoney.Text)).ToString();
						else
							currMoneyup = (Double.Parse(currMoneyup) - Double.Parse(txtMoney.Text)).ToString();

						if(Double.Parse(currMoneyup) < 0)
						{
							throw(new Exception("잔액이 부족합니다!!\n확인후 다시 입력하세요."));					
						}

						queryString = "UPDATE DivMoney SET currMoney='"+ currMoneyup +"' WHERE seq="+ cbDiv.SelectedValue + ";";
				
						myCmd.CommandText = queryString;

						myCmd.ExecuteNonQuery();
						myCmd.Transaction.Commit();//트랜잭션 성공
					}
					else
					{
						MessageBox.Show("잔고가 마이너스가 될수 없습니다.");
					}
					lvLast.Items.Clear();
					lvDiv.Items.Clear();
					DivLoad();
					LastLoad();
				}
				catch(Exception ee)
				{
					myCmd.Transaction.Rollback();//트랜잭션 실패
					MessageBox.Show(ee.Message);
				}
				finally
				{
					myConn.Close();
					txtContent.Text ="";
					txtMoney.Text="";

				}
				return 1;
			}
				return 0;
		}

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if(SortProcess() == 0)
			{
				string uniDate = "";
				uniDate = cbYear.Text +"-"+ cbMonth.Text +"-"+ cbDay.Text;

				myConn = new OleDbConnection (connString);
				OleDbCommand myCmd = new OleDbCommand("", myConn);
				try
				{
					////////// LogMoney 로그 추가
					string moneyIn="0", moneyOut="0";
					if(cbInOut.SelectedIndex == 1)
					{
						moneyIn = txtMoney.Text;
						sumMoney = sumMoney+Double.Parse(txtMoney.Text);
					}
					else
					{
						sumMoney = sumMoney-Double.Parse(txtMoney.Text);
						moneyOut = txtMoney.Text;
					}

					string queryString =
						String.Format ("INSERT INTO LogMoney(logDate, content, inMoney, outMoney, currMoney, div) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", uniDate, txtContent.Text, moneyIn, moneyOut, sumMoney, cbDiv.Text);

					myConn.Open();

					myCmd.CommandText = queryString;
				
					myCmd.Transaction = myConn.BeginTransaction();// 트랜잭션시작

					myCmd.ExecuteNonQuery();

					////////// DivMoney 업데이트
					string currMoney = (lvDiv.Items[cbDiv.SelectedIndex].SubItems[1].Text.Replace("\\","")).Replace(",","");
					if(currMoney == "")
						currMoney = "0";
				
					if(cbInOut.SelectedIndex == 1)
						currMoney = (Double.Parse(currMoney) + Double.Parse(txtMoney.Text)).ToString();
					else
						currMoney = (Double.Parse(currMoney) - Double.Parse(txtMoney.Text)).ToString();

					if(Double.Parse(currMoney) < 0)
					{
						throw(new Exception("잔액이 부족합니다!!\n확인후 다시 입력하세요."));					
					}

					queryString = "UPDATE DivMoney SET currMoney='"+ currMoney +"' WHERE seq="+ cbDiv.SelectedValue + ";";
				
					myCmd.CommandText = queryString;

					myCmd.ExecuteNonQuery();
				
					myCmd.Transaction.Commit();//트랜잭션 성공

					lvDiv.Items.Clear();
					lvLast.Items.Clear();
					DivLoad();
					LastLoad();
				}
				catch(Exception)
				{
					myCmd.Transaction.Rollback();//트랜잭션 실패
				}
				finally
				{
					myConn.Close();
					txtContent.Text ="";
					txtMoney.Text="";
				}

			}
		}

		// 각각 금액 액수 출력
		private void DivLoad()
		{
			myConn = new OleDbConnection (connString);
			string [] tmp = new string[2];
			sumMoney = 0;
			try
			{
				myConn = new OleDbConnection (connString);

				string queryString = "SELECT * FROM DivMoney";
				myDa = new OleDbDataAdapter(queryString, myConn);

				myDs = new DataSet();
			
				myDa.Fill (myDs,"DB");

				for( int i=0; i< myDs.Tables["DB"].Rows.Count; i++)
				{
					tmp[0] = myDs.Tables["DB"].Rows[i].ItemArray[1].ToString().Trim();
					tmp[1] = myDs.Tables["DB"].Rows[i].ItemArray[2].ToString().Trim();

					sumMoney += Double.Parse(tmp[1]);

					tmp[1] = String.Format("\\{0:#,###}",Double.Parse(tmp[1]));

					ListViewItem lvItem = new ListViewItem(tmp, 0);
					lvDiv.Items.Add(lvItem);
				}
				lblTotal.Text = String.Format("\\{0:#,###}", sumMoney);
			}
			catch(Exception)
			{
			}
			finally
			{
				myConn.Close();
			}
		}

		//최근 내역 출력
		private void LastLoad()
		{
			myConn = new OleDbConnection (connString);
			string [] tmp = new string[6];

			try
			{
				string queryString = "SELECT top 5 logDate, content, inMoney, outMoney, currMoney,div FROM LogMoney Order By logDate DESC, seq DESC";
				myDa = new OleDbDataAdapter(queryString, myConn);

				myDs = new DataSet();
			
				myDa.Fill (myDs,"DB");

				for( int i=0; i< myDs.Tables["DB"].Rows.Count; i++)
				{
					tmp[0] = myDs.Tables["DB"].Rows[i].ItemArray[0].ToString().Trim().Substring(6,4);
					tmp[1] = myDs.Tables["DB"].Rows[i].ItemArray[1].ToString().Trim();
					tmp[2] = String.Format("{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[2].ToString().Trim()));
					tmp[3] = String.Format("{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[3].ToString().Trim()));
					tmp[4] = String.Format("\\{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[4].ToString().Trim()));
					tmp[5] = myDs.Tables["DB"].Rows[i].ItemArray[5].ToString().Trim();

					ListViewItem lvItem = new ListViewItem(tmp, 0);
					lvLast.Items.Add(lvItem);
				}
			}
			catch(Exception)
			{
			}
			finally
			{
				myConn.Close();
			}
		}

		// 종류 콤보박스 로딩
		private void CbDivLoad()
		{
			myConn = new OleDbConnection (connString);

			try
			{
				myConn = new OleDbConnection (connString);

				string queryString = "SELECT seq, div FROM DivMoney";
				myDa = new OleDbDataAdapter(queryString, myConn);

				myDs = new DataSet();
			
				myDa.Fill (myDs,"DB");

				cbDiv.DataSource = myDs.Tables[0].DefaultView;
				cbDiv.SelectedIndex = 0;
			}
			catch(Exception)
			{
			}
			finally
			{
				myConn.Close();
			}
		}

		private void btnListView_Click(object sender, System.EventArgs e)
		{
			WalletList wl = new WalletList(lblTotal.Text.Replace("\\","").Replace(",",""));
			wl.ShowDialog(this);
			lvDiv.Items.Clear();
			lvLast.Items.Clear();
			DivLoad();
			LastLoad();
		}

		private void btnDivManager_Click(object sender, System.EventArgs e)
		{
			DivManager dm = new DivManager();
			dm.ShowDialog(this);
			lvDiv.Items.Clear();
			lvLast.Items.Clear();
			DivLoad();
			LastLoad();
			CbDivLoad();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			txtContent.Text ="";
			txtMoney.Text="";
		}

		private void txtMoney_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)

				InvokeOnClick (btnSubmit, e);
		}

		private void btnCalc_Click(object sender, System.EventArgs e)
		{
			Process.Start("calc.exe");
		}

		private void btnAn_Click(object sender, System.EventArgs e)
		{
			Analysis an = new Analysis();
			an.ShowDialog(this);
		}

		private void btnMemo_Click(object sender, System.EventArgs e)
		{
			Memo memo = new Memo();
			memo.ShowDialog(this);
		}
	}
}
