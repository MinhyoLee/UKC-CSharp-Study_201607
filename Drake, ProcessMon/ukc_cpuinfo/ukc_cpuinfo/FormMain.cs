using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukc_cpuinfo
{
    public partial class FormMain : Form
    {
        private int t = 0;
        private Series cpu, ram;
        private PerformanceCounter cpuc, memc;
        private int initpc()
        {
            cpuc = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            memc = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            return 0;
        }
        public FormMain()
        {
            InitializeComponent();
            initpc();
            Chart_CPU.Series.Clear();
            cpu = Chart_CPU.Series.Add("CPU");
            ram = Chart_CPU.Series.Add("RAM");
            cpu.ChartType = SeriesChartType.Column;
            ram.ChartType = SeriesChartType.Column;
            cpu.Points.Add(0);
            ram.Points.Add(0);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            label1.Text = "CPU 사용량 : " + cpuc.NextValue().ToString();
            label2.Text = "메모리 사용량 : " + memc.NextValue().ToString();
            cpu.Points.Clear();
            cpu.Points.Add(cpuc.NextValue());
            ram.Points.Clear();
            ram.Points.Add(memc.NextValue());

        }
    }
}
