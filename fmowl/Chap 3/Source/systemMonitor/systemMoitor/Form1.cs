using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace systemMoitor
{
    public partial class Form1 : Form
    {
        PerformanceCounter cpu;
        PerformanceCounter ram;
        int i;

        public Form1()
        {
            InitializeComponent();
            cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ram = new PerformanceCounter("Process", "Working Set", "_Total");
            i = 0;
            timer1.Interval = 500;
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            usageChart.Series.Add("CPU");
            //usageChart.Series.Add("Ram");
            usageChart.Series[0].IsVisibleInLegend = false;
            //usageChart.Series[1].IsVisibleInLegend = false;
            usageChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            //usageChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            usageChart.ChartAreas[0].AxisY.Maximum = 100;
            usageChart.Series[0].Color = Color.FromArgb(0x40,0xff,0x00,0x00);
            //usageChart.Series[1].Color = Color.FromArgb(0x0f, 0x00, 0x00, 0xff);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usageChart.Series[0].Points.AddXY(i,(int) cpu.NextValue());
            //usageChart.Series[1].Points.AddXY(i, ram.NextSample());
            i++;
        }
    }
}
