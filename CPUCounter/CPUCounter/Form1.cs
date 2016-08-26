using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;


namespace CPUCounter
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        int cpuVal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpuChart.Series.Clear();
            Series sCpu = cpuChart.Series.Add("cpuCount");
            sCpu.ChartType = SeriesChartType.Column;

            cpuChart.ChartAreas[0].AxisY.Interval = 10;
            cpuChart.ChartAreas[0].AxisX.Minimum = 0;
            cpuChart.ChartAreas[0].AxisY.Minimum = 0;
            cpuChart.ChartAreas[0].AxisX.Maximum = 5;
            cpuChart.ChartAreas[0].AxisY.Maximum = 100;

            InitPerformanceCounter();
            GetValue();

            Delay(200);

            sCpu.Points.AddXY(0, cpuCounter.NextValue());

            Delay(200);

            lblcpuCounter.Text = cpuCounter.NextValue().ToString() + "%";

        }

        private void InitPerformanceCounter()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }
        private void GetValue()
        {
            cpuVal = (int)cpuCounter.NextValue();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cpuChart.Series.Clear();
            cpuCounter.Close();
        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

    }

}
