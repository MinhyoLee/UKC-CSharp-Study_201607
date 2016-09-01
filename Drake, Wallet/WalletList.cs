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
	/// WalletList에 대한 요약 설명입니다.
	/// </summary>
	public class WalletList : Config
	{
		private DataSet myDs;
		private OleDbDataAdapter myDa;
		private OleDbConnection myConn;

		private double sumInMoney, sumOutMoney, total;
		private bool chk = false;

		private System.Windows.Forms.ColumnHeader ColumnHeader11;
		private System.Windows.Forms.ColumnHeader ColumnHeader12;
		private System.Windows.Forms.ColumnHeader ColumnHeader13;
		private System.Windows.Forms.ColumnHeader ColumnHeader14;
		private System.Windows.Forms.ColumnHeader ColumnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ListView lvFullList;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.ComboBox cbDay;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btn30day;
		private System.Windows.Forms.Button btn7day;
		private System.Windows.Forms.ComboBox cbDiv;
		private System.Windows.Forms.ComboBox cbPre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbDay2;
		private System.Windows.Forms.ComboBox cbMonth2;
		private System.Windows.Forms.ComboBox cbYear2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel DivPanel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox cbExtend;
		private System.Windows.Forms.Label lblTotIn;
		private System.Windows.Forms.Label lblTotOut;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnClose;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public WalletList()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		public WalletList(string total)
		{
			InitializeComponent();
			this.total = Double.Parse(total);
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
			this.lvFullList = new System.Windows.Forms.ListView();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbExtend = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbPre = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbDiv = new System.Windows.Forms.ComboBox();
			this.btn7day = new System.Windows.Forms.Button();
			this.btn30day = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbDay = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.DivPanel = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbDay2 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbYear2 = new System.Windows.Forms.ComboBox();
			this.cbMonth2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblTotIn = new System.Windows.Forms.Label();
			this.lblTotOut = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.DivPanel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvFullList
			// 
			this.lvFullList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvFullList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader10,
																						 this.ColumnHeader11,
																						 this.ColumnHeader12,
																						 this.ColumnHeader13,
																						 this.ColumnHeader14,
																						 this.ColumnHeader15,
																						 this.columnHeader16});
			this.lvFullList.FullRowSelect = true;
			this.lvFullList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvFullList.Location = new System.Drawing.Point(8, 104);
			this.lvFullList.Name = "lvFullList";
			this.lvFullList.Size = new System.Drawing.Size(528, 357);
			this.lvFullList.TabIndex = 5;
			this.lvFullList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Seq";
			this.columnHeader10.Width = 0;
			// 
			// ColumnHeader11
			// 
			this.ColumnHeader11.Text = "날짜";
			this.ColumnHeader11.Width = 81;
			// 
			// ColumnHeader12
			// 
			this.ColumnHeader12.Text = "내용";
			this.ColumnHeader12.Width = 149;
			// 
			// ColumnHeader13
			// 
			this.ColumnHeader13.Text = "수입";
			this.ColumnHeader13.Width = 70;
			// 
			// ColumnHeader14
			// 
			this.ColumnHeader14.Text = "지출";
			this.ColumnHeader14.Width = 63;
			// 
			// ColumnHeader15
			// 
			this.ColumnHeader15.Text = "잔고";
			this.ColumnHeader15.Width = 85;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "구분";
			this.columnHeader16.Width = 62;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "해당 일자";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbExtend);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbPre);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbDiv);
			this.groupBox1.Controls.Add(this.btn7day);
			this.groupBox1.Controls.Add(this.btn30day);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.cbDay);
			this.groupBox1.Controls.Add(this.cbMonth);
			this.groupBox1.Controls.Add(this.cbYear);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.DivPanel);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(440, 88);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "조건별 조회";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// cbExtend
			// 
			this.cbExtend.Location = new System.Drawing.Point(224, 17);
			this.cbExtend.Name = "cbExtend";
			this.cbExtend.Size = new System.Drawing.Size(48, 24);
			this.cbExtend.TabIndex = 29;
			this.cbExtend.Text = "확장";
			this.cbExtend.CheckedChanged += new System.EventHandler(this.cbExtend_CheckedChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(208, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "일";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 23);
			this.label3.TabIndex = 20;
			this.label3.Text = "월";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbPre
			// 
			this.cbPre.Items.AddRange(new object[] {
													   "이전",
													   "이후"});
			this.cbPre.Location = new System.Drawing.Point(224, 40);
			this.cbPre.Name = "cbPre";
			this.cbPre.Size = new System.Drawing.Size(48, 20);
			this.cbPre.TabIndex = 19;
			this.cbPre.Text = "이전";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(288, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 18;
			this.label1.Text = "종류별";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbDiv
			// 
			this.cbDiv.DisplayMember = "div";
			this.cbDiv.Location = new System.Drawing.Point(288, 40);
			this.cbDiv.Name = "cbDiv";
			this.cbDiv.Size = new System.Drawing.Size(80, 20);
			this.cbDiv.TabIndex = 17;
			this.cbDiv.Text = "Div";
			this.cbDiv.ValueMember = "seq";
			// 
			// btn7day
			// 
			this.btn7day.Location = new System.Drawing.Point(80, 16);
			this.btn7day.Name = "btn7day";
			this.btn7day.Size = new System.Drawing.Size(64, 23);
			this.btn7day.TabIndex = 16;
			this.btn7day.Text = "1주일";
			this.btn7day.Click += new System.EventHandler(this.btn7day_Click);
			// 
			// btn30day
			// 
			this.btn30day.Location = new System.Drawing.Point(144, 16);
			this.btn30day.Name = "btn30day";
			this.btn30day.Size = new System.Drawing.Size(64, 23);
			this.btn30day.TabIndex = 15;
			this.btn30day.Text = "한달";
			this.btn30day.Click += new System.EventHandler(this.btn30day_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(376, 32);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(56, 40);
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "조회";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
			this.cbDay.Location = new System.Drawing.Point(160, 40);
			this.cbDay.Name = "cbDay";
			this.cbDay.Size = new System.Drawing.Size(48, 20);
			this.cbDay.TabIndex = 13;
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
			this.cbMonth.Location = new System.Drawing.Point(96, 40);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(48, 20);
			this.cbMonth.TabIndex = 12;
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
			this.cbYear.Location = new System.Drawing.Point(16, 40);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(64, 20);
			this.cbYear.TabIndex = 11;
			this.cbYear.Text = "년";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "년";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DivPanel
			// 
			this.DivPanel.Controls.Add(this.label9);
			this.DivPanel.Controls.Add(this.label7);
			this.DivPanel.Controls.Add(this.cbDay2);
			this.DivPanel.Controls.Add(this.label8);
			this.DivPanel.Controls.Add(this.cbYear2);
			this.DivPanel.Controls.Add(this.cbMonth2);
			this.DivPanel.Controls.Add(this.label6);
			this.DivPanel.Controls.Add(this.label10);
			this.DivPanel.Location = new System.Drawing.Point(16, 64);
			this.DivPanel.Name = "DivPanel";
			this.DivPanel.Size = new System.Drawing.Size(272, 20);
			this.DivPanel.TabIndex = 28;
			this.DivPanel.Visible = false;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(232, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 15);
			this.label9.TabIndex = 28;
			this.label9.Text = "까지";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(152, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 15);
			this.label7.TabIndex = 26;
			this.label7.Text = "월";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbDay2
			// 
			this.cbDay2.Items.AddRange(new object[] {
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
			this.cbDay2.Location = new System.Drawing.Point(168, 0);
			this.cbDay2.Name = "cbDay2";
			this.cbDay2.Size = new System.Drawing.Size(48, 20);
			this.cbDay2.TabIndex = 25;
			this.cbDay2.Text = "일";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(88, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 15);
			this.label8.TabIndex = 24;
			this.label8.Text = "년";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbYear2
			// 
			this.cbYear2.Items.AddRange(new object[] {
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
			this.cbYear2.Location = new System.Drawing.Point(24, 0);
			this.cbYear2.Name = "cbYear2";
			this.cbYear2.Size = new System.Drawing.Size(64, 20);
			this.cbYear2.TabIndex = 22;
			this.cbYear2.Text = "년";
			// 
			// cbMonth2
			// 
			this.cbMonth2.Items.AddRange(new object[] {
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
			this.cbMonth2.Location = new System.Drawing.Point(104, 0);
			this.cbMonth2.Name = "cbMonth2";
			this.cbMonth2.Size = new System.Drawing.Size(48, 20);
			this.cbMonth2.TabIndex = 23;
			this.cbMonth2.Text = "월";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(216, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 15);
			this.label6.TabIndex = 27;
			this.label6.Text = "일";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(8, 3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 15);
			this.label10.TabIndex = 29;
			this.label10.Text = "~";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotIn
			// 
			this.lblTotIn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblTotIn.ForeColor = System.Drawing.Color.IndianRed;
			this.lblTotIn.Location = new System.Drawing.Point(80, 464);
			this.lblTotIn.Name = "lblTotIn";
			this.lblTotIn.Size = new System.Drawing.Size(72, 23);
			this.lblTotIn.TabIndex = 13;
			this.lblTotIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotOut
			// 
			this.lblTotOut.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblTotOut.ForeColor = System.Drawing.Color.RoyalBlue;
			this.lblTotOut.Location = new System.Drawing.Point(224, 464);
			this.lblTotOut.Name = "lblTotOut";
			this.lblTotOut.Size = new System.Drawing.Size(80, 23);
			this.lblTotOut.TabIndex = 14;
			this.lblTotOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 464);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 15;
			this.label11.Text = "수입 합계";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(152, 464);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 23);
			this.label12.TabIndex = 16;
			this.label12.Text = "지출 합계";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(304, 464);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 17;
			this.label13.Text = "Total";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblTotal.ForeColor = System.Drawing.Color.Red;
			this.lblTotal.Location = new System.Drawing.Point(360, 464);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(80, 23);
			this.lblTotal.TabIndex = 18;
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(8, 24);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(64, 24);
			this.btnUpdate.TabIndex = 19;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDel);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Location = new System.Drawing.Point(456, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(80, 88);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "선택항목";
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(8, 56);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(64, 24);
			this.btnDel.TabIndex = 20;
			this.btnDel.Text = "삭제";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(472, 466);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 22);
			this.btnClose.TabIndex = 21;
			this.btnClose.Text = "닫기";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// WalletList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(544, 493);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lblTotOut);
			this.Controls.Add(this.lblTotIn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lvFullList);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "WalletList";
			this.Text = "WalletList";
			this.Load += new System.EventHandler(this.WalletList_Load);
			this.groupBox1.ResumeLayout(false);
			this.DivPanel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void WalletList_Load(object sender, System.EventArgs e)
		{
			this.AcceptButton = btnSearch;
			string date = "";
			date = DateTime.Now.ToShortDateString().ToString().Replace("-","");
			
			cbYear.Text = date.Substring(0,4);
			cbMonth.Text = date.Substring(4,2);
			cbDay.Text = date.Substring(6,2);
			
			cbYear2.Text = date.Substring(0,4);
			cbMonth2.Text = date.Substring(4,2);
			cbDay2.Text = date.Substring(6,2);	

			ListLoad();
			CbDivLoad();
		}


		// 리스트 로딩
		private void ListLoad()
		{
			sumInMoney = 0;
			sumOutMoney = 0;

			myConn = new OleDbConnection (connString);
			string [] tmp = new string[7];

			try
			{
				lvFullList.Items.Clear();

				string opr = ">=";
				string div = "";
				string queryString = "";

				if (cbPre.SelectedIndex == 1)
					opr = "<=";

				if ((int)cbDiv.SelectedIndex != 0)
					div = "AND div = '" + cbDiv.Text +"'";
				else
					div = "";

				if (chk==false)
				{
					queryString = "SELECT seq, logdate, content, inMoney, outMoney, currMoney, div FROM LogMoney Order By logDate Desc,seq Desc";
				}else if (cbExtend.Checked == true)
					queryString = "SELECT seq, logdate, content, inMoney, outMoney, currMoney, div FROM LogMoney " +
						"WHERE logdate >= '"+ cbYear.Text +"-"+cbMonth.Text+"-"+cbDay.Text+"' " +
						"AND logdate <= '"+ cbYear2.Text +"-"+cbMonth2.Text+"-"+cbDay2.Text+"' " +
						div +"  Order By logDate Desc,seq Desc";
				else
					queryString = "SELECT seq, logdate, content, inMoney, outMoney, currMoney, div FROM LogMoney " +
						"WHERE logdate "+opr+" '"+ cbYear.Text +"-"+cbMonth.Text+"-"+cbDay.Text+"' " +
						div +"  Order By logDate Desc,seq Desc";
				
				myConn = new OleDbConnection (connString);

				myDa = new OleDbDataAdapter(queryString, myConn);

				myDs = new DataSet();
			
				myDa.Fill (myDs,"DB");

				for( int i=0; i< myDs.Tables["DB"].Rows.Count; i++)
				{
					sumInMoney += Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[3].ToString().Trim());
					sumOutMoney += Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[4].ToString().Trim());

					tmp[0] = myDs.Tables["DB"].Rows[i].ItemArray[0].ToString().Trim();
					tmp[1] = myDs.Tables["DB"].Rows[i].ItemArray[1].ToString().Trim();
					tmp[2] = myDs.Tables["DB"].Rows[i].ItemArray[2].ToString().Trim();
					tmp[3] = String.Format("{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[3].ToString().Trim()));
					tmp[4] = String.Format("{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[4].ToString().Trim()));
					tmp[5] = String.Format("\\{0:#,###}",Double.Parse(myDs.Tables["DB"].Rows[i].ItemArray[5].ToString().Trim()));
					tmp[6] = myDs.Tables["DB"].Rows[i].ItemArray[6].ToString().Trim();

					ListViewItem lvItem = new ListViewItem(tmp, 0);
					lvFullList.Items.Add(lvItem);
				}

				lblTotIn.Text = String.Format("{0:#,###}",sumInMoney);
				lblTotOut.Text = String.Format("{0:#,###}",sumOutMoney);
				lblTotal.Text = String.Format("{0:#,###}",sumInMoney-sumOutMoney);
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
		
		// 종류 콤보박스 로딩
		private void CbDivLoad()
		{
			OleDbDataReader DataBuffer;

			myConn = new OleDbConnection (connString);
			try
			{
				myConn = new OleDbConnection (connString);

				string queryString = "SELECT seq, div FROM DivMoney";

				myConn.Open();
				OleDbCommand UserCmd = new  OleDbCommand (queryString,myConn); 
				DataBuffer = UserCmd.ExecuteReader();   
				
				cbDiv.Items.Add("전    체");
				while( DataBuffer.Read() )
				{
					this.cbDiv.Items.Add( DataBuffer["div"].ToString() );  
				}

				DataBuffer.Close();
				myConn.Close();

				cbDiv.SelectedIndex = 0;
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

		// 일주일 전 지정
		private void btn7day_Click(object sender, System.EventArgs e)
		{
			string date = DateTime.Now.AddDays(-7).ToShortDateString().ToString().Replace("-","");
			
			cbYear.Text = date.Substring(0,4);
			cbMonth.Text = date.Substring(4,2);
			cbDay.Text = date.Substring(6,2);		
		}

		// 한달 전 지정
		private void btn30day_Click(object sender, System.EventArgs e)
		{
			string date = DateTime.Now.AddDays(-30).ToShortDateString().ToString().Replace("-","");
			
			cbYear.Text = date.Substring(0,4);
			cbMonth.Text = date.Substring(4,2);
			cbDay.Text = date.Substring(6,2);	
		}

		// 조회 처리
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			chk = true;
			ListLoad();
		}
		
		// 확장 조회
		private void cbExtend_CheckedChanged(object sender, System.EventArgs e)
		{
			if(cbExtend.Checked == true)
			{
				DivPanel.Visible = true;
				cbPre.Visible = false;
			}
			else
			{
				DivPanel.Visible = false;
				cbPre.Visible = true;
			}
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			string seqNo="",money="",div="";
			string date="";
			double inTmp=0,outTmp=0,currTmp=0;

			foreach ( ListViewItem list in lvFullList.Items )
			{					
				if( list.Selected )
				{	
					seqNo = list.SubItems[0].Text.ToString();				
					div = list.SubItems[6].Text.ToString();
					date= list.SubItems[1].Text.ToString();

					inTmp= Double.Parse((list.SubItems[3].Text.ToString().Replace(",","")==""?"0":list.SubItems[3].Text.ToString().Replace(",","")));
					outTmp= Double.Parse((list.SubItems[4].Text.ToString().Replace(",","")==""?"0":list.SubItems[4].Text.ToString().Replace(",","")));
					currTmp= Double.Parse(list.SubItems[5].Text.ToString().Replace(",","").Replace("\\",""));

					currTmp = ((currTmp+outTmp)-inTmp);
					
					if(list.SubItems[3].Text.ToString() != "")
					{
						money = "currMoney-"+list.SubItems[3].Text.ToString().Replace(",","");
						total = total - Double.Parse(list.SubItems[3].Text.ToString().Replace(",",""));
					}
					else
					{
						money = "currMoney+"+list.SubItems[4].Text.ToString().Replace(",","");
						total = total + Double.Parse(list.SubItems[4].Text.ToString().Replace(",",""));
					}
				}
			}
			
			if(total > 0)
			{
				string message = "● 확인을 누르시면 삭제 됩니다.\n● 삭제된 대상은 다시 환급됩니다.";
				string caption = "선택하신 대상이 삭제 됩니다.";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result=DialogResult.No;
				
				if(seqNo != "")
					result = MessageBox.Show(this, message, caption, buttons);
				else
					MessageBox.Show("삭제할 리스트를 선택하세요!!");

				if(result == DialogResult.Yes)
				{
					myConn = new OleDbConnection (connString);
					OleDbCommand myCmd = new OleDbCommand("", myConn);
					try
					{
						myConn.Open();
						//////////////////////////////////////////////////////// 로그복구

						string query = "SELECT seq,inMoney,outMoney,currMoney FROM LogMoney WHERE logDate >= '"+ date + "' " +
							"AND seq NOT IN(SELECT seq FROM LogMoney WHERE logDate = '"+date+"' AND seq <= "+seqNo+")"+
							"Order By logDate Asc ,seq ASC";

						myDa = new OleDbDataAdapter(query, myConn);

						myDs = new DataSet();

						myDa.Fill(myDs, "DB");
						myCmd.Transaction = myConn.BeginTransaction();// 트랜잭션시작

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
			
								int chk = 0;
								for(int j = 0; j < myDs.Tables["DB"].Rows.Count; j++)
								{
									if(j == 0)
										currMoney[j] = (currTmp+inMoney[j])-outMoney[j];
									else
										currMoney[j] = (currMoney[j-1]+inMoney[j])-outMoney[j];

									if(currMoney[j] < 0)
										chk=1;
								}

								if(chk == 0)
								{
									for(int l = 0; l < myDs.Tables["DB"].Rows.Count; l++)
									{
										myCmd.CommandText = "Update LogMoney Set currMoney = '"+ currMoney[l].ToString() +"' WHERE seq="+seq[l];
										myCmd.ExecuteNonQuery();
									}
								}
								else
								{
									MessageBox.Show("잔고가 마이너스가 될수 없습니다.");
								}

								////////// 삭제된값 복원

								myCmd.CommandText = "UPDATE DivMoney SET currMoney = "+money+" WHERE div='"+ div + "';";
								myCmd.ExecuteNonQuery();
						}
						string queryString =
							String.Format ("DELETE FROM LogMoney WHERE seq = {0}", seqNo);
						myCmd.CommandText = queryString;
						myCmd.ExecuteNonQuery();

						myCmd.Transaction.Commit();//트랜잭션 성공
						lvFullList.Items.Clear();
						ListLoad();

					}
					catch(Exception ee)
					{
						myCmd.Transaction.Rollback();//트랜잭션 실패
						MessageBox.Show(ee.Message);
						MessageBox.Show("삭제할 리스트를 선택하세요!!");
					}
					finally
					{
						myConn.Close();
					}						
				}
			}	
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			string seq="",logdate="",content="";
			try
			{
				foreach ( ListViewItem list in lvFullList.Items )
				{					
					if( list.Selected )
					{	
						seq = list.SubItems[0].Text.ToString();
						logdate = list.SubItems[1].Text.ToString();
						content = list.SubItems[2].Text.ToString();
					}
				}
				
				UpdateList ul = new UpdateList(seq,logdate,content);
				
				ul.ShowDialog(this);

				ListLoad();
			}
			catch(Exception)
			{
				MessageBox.Show("수정 할 리스트를 선택하세요!!");
			}
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}
	}
}
