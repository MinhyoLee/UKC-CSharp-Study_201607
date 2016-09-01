using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;
//using SoftwareFX.ChartFX.Lite;

namespace e_wallet
{
	/// <summary>
	/// Analysis에 대한 요약 설명입니다.
	/// </summary>
	public class Analysis : Config
	{
		private OleDbCommand myComm;
		private OleDbConnection myConn;
		private OleDbDataReader myReader;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
//		private SoftwareFX.ChartFX.Lite.Chart chart1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Analysis()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
//			this.chart1 = new SoftwareFX.ChartFX.Lite.Chart();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.cbYear);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 72);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "년별 통계";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(144, 24);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 40);
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "조회";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "조회년도";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// chart1
			// 
			//this.chart1.AxisX.Title.Text = "Month";
			//this.chart1.AxisY.LabelsFormat.CustomFormat = "###,###,###";
			//this.chart1.AxisY.LabelsFormat.Decimals = 0;
			//this.chart1.AxisY.Title.Text = "Money";
			//this.chart1.Chart3D = true;
			//this.chart1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			//this.chart1.LineWidth = 2;
			//this.chart1.Location = new System.Drawing.Point(8, 88);
			//this.chart1.Name = "chart1";
			//this.chart1.Size = new System.Drawing.Size(691, 258);
			//this.chart1.TabIndex = 13;
			// 
			// Analysis
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(712, 357);
//			this.Controls.Add(this.chart1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Analysis";
			this.Text = "Analysis";
			this.Load += new System.EventHandler(this.Analysis_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void DrawGrape()
		{
			string startDate = cbYear.Text+"-01-01";
			string endDate = cbYear.Text+"-12-31";
			string[] month = new string[12];

			for (int j=0; j < month.Length; j++)
			{
				if(j<12)
					month[j]="0"+(j+1);
				else
					month[j]=(j+1).ToString();
			}

			// Start from original chart
//			chart1.Gallery = Gallery.Lines; //It requires: Imports SoftwareFX.ChartFX.Lite
			// Set X/Y data
//			chart1.OpenData(COD.Values | COD.Remove, 2, 12);   //It requires: Imports SoftwareFX.ChartFX.Lite
			
			try
			{
				myConn = new OleDbConnection (connString);
				myConn.Open();

				// Format Primary Y-Axis
//				chart1.SerLeg.Clear();

//				chart1.SerLeg[0] = "수입"; // 라벨
//				chart1.SerLeg[1] = "지출"; // 라벨

				for(int i=0; i<12; i++)
				{
					string query = "SELECT Sum(inMoney) AS inSum, Sum(outMoney) AS outSum FROM LogMoney "+
						"HAVING ( logDate Like '"+cbYear.Text+"-"+month[i]+"-%' "+
						"AND logdate >= '"+startDate+"' AND logdate <= '"+endDate+"')";
					
					myComm = new OleDbCommand("", myConn);
					myComm.CommandText = query;

					myReader = myComm.ExecuteReader();

					while(myReader.Read())
					{					
						double sum1 = 0,sum2 = 0;

						if(myReader["inSum"].ToString() == "")
							sum1 = 0;
						else
							sum1 = Double.Parse(myReader["inSum"].ToString());

						if(myReader["outSum"].ToString() == "")
							sum2 = 0;
						else
							sum2 = Double.Parse(myReader["outSum"].ToString());
						
						//chart1.Value[0, i] = sum1;
						//chart1.Value[1, i] = sum2;
						//chart1.Legend[i] = System.Convert.ToString(i + 1);
					}
					myReader.Close();
				}
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
			finally
			{
				myConn.Close();
			}

			//chart1.CloseData(COD.Values); //It requires: Imports SoftwareFX.ChartFX.Lite

			// make second series a line
  
			// Format X-Axis
			//chart1.AxisX.Gridlines = true;

			//chart1.SerLegBox = true;
		}
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			DrawGrape();
		}

		private void Analysis_Load(object sender, System.EventArgs e)
		{
			cbYear.Text = DateTime.Now.ToShortDateString().Substring(0,4);
			DrawGrape();
		}
		
	}
}
