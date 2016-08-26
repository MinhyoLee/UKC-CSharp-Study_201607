namespace CPUCounter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblcpuCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuChart
            // 
            chartArea2.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea2);
            this.cpuChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.cpuChart.Legends.Add(legend2);
            this.cpuChart.Location = new System.Drawing.Point(0, 0);
            this.cpuChart.Name = "cpuChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cpuChart.Series.Add(series2);
            this.cpuChart.Size = new System.Drawing.Size(615, 432);
            this.cpuChart.TabIndex = 0;
            this.cpuChart.Text = "chart1";
            // 
            // lblcpuCounter
            // 
            this.lblcpuCounter.AutoSize = true;
            this.lblcpuCounter.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblcpuCounter.Location = new System.Drawing.Point(261, 458);
            this.lblcpuCounter.Name = "lblcpuCounter";
            this.lblcpuCounter.Size = new System.Drawing.Size(52, 40);
            this.lblcpuCounter.TabIndex = 1;
            this.lblcpuCounter.Text = "%";
            this.lblcpuCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 559);
            this.Controls.Add(this.lblcpuCounter);
            this.Controls.Add(this.cpuChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Label lblcpuCounter;
    }
}

