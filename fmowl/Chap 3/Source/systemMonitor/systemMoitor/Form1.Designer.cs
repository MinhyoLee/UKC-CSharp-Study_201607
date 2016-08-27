namespace systemMoitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CPUButton = new System.Windows.Forms.Button();
            this.RAMButton = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.graphTab = new System.Windows.Forms.TabPage();
            this.usageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.processListTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAMUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab.SuspendLayout();
            this.graphTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageChart)).BeginInit();
            this.processListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPUButton
            // 
            this.CPUButton.Location = new System.Drawing.Point(6, 85);
            this.CPUButton.Name = "CPUButton";
            this.CPUButton.Size = new System.Drawing.Size(104, 98);
            this.CPUButton.TabIndex = 0;
            this.CPUButton.Text = "CPU";
            this.CPUButton.UseVisualStyleBackColor = true;
            // 
            // RAMButton
            // 
            this.RAMButton.Location = new System.Drawing.Point(6, 226);
            this.RAMButton.Name = "RAMButton";
            this.RAMButton.Size = new System.Drawing.Size(104, 98);
            this.RAMButton.TabIndex = 1;
            this.RAMButton.Text = "RAM";
            this.RAMButton.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.graphTab);
            this.tab.Controls.Add(this.processListTab);
            this.tab.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(595, 610);
            this.tab.TabIndex = 2;
            // 
            // graphTab
            // 
            this.graphTab.Controls.Add(this.usageChart);
            this.graphTab.Controls.Add(this.CPUButton);
            this.graphTab.Controls.Add(this.RAMButton);
            this.graphTab.Location = new System.Drawing.Point(4, 24);
            this.graphTab.Name = "graphTab";
            this.graphTab.Padding = new System.Windows.Forms.Padding(3);
            this.graphTab.Size = new System.Drawing.Size(587, 582);
            this.graphTab.TabIndex = 0;
            this.graphTab.Text = "CPU RAM Graph";
            this.graphTab.UseVisualStyleBackColor = true;
            // 
            // usageChart
            // 
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.Name = "ChartArea1";
            this.usageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.usageChart.Legends.Add(legend1);
            this.usageChart.Location = new System.Drawing.Point(152, 24);
            this.usageChart.Name = "usageChart";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.usageChart.Series.Add(series1);
            this.usageChart.Size = new System.Drawing.Size(415, 545);
            this.usageChart.TabIndex = 2;
            this.usageChart.Text = "Graph";
            // 
            // processListTab
            // 
            this.processListTab.Controls.Add(this.listView1);
            this.processListTab.Location = new System.Drawing.Point(4, 24);
            this.processListTab.Name = "processListTab";
            this.processListTab.Padding = new System.Windows.Forms.Padding(3);
            this.processListTab.Size = new System.Drawing.Size(587, 582);
            this.processListTab.TabIndex = 1;
            this.processListTab.Text = "ProcessList";
            this.processListTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.ID,
            this.RAMUsage});
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 572);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "ProcessName";
            this.ProcessName.Width = 244;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 54;
            // 
            // RAMUsage
            // 
            this.RAMUsage.Text = "RamUsage";
            this.RAMUsage.Width = 274;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 634);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.graphTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usageChart)).EndInit();
            this.processListTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CPUButton;
        private System.Windows.Forms.Button RAMButton;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage graphTab;
        private System.Windows.Forms.TabPage processListTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart usageChart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader RAMUsage;
        private System.Windows.Forms.Timer timer1;
    }
}

