using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ResourceCollectingService
{
    public partial class Service1 : ServiceBase
    {
        private PerformanceCounter CpuCounter { get; set; }
        private PerformanceCounter MemoryCounter { get; set; }

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            MemoryCounter = new PerformanceCounter("Memory", "Available KBytes");
            timerCollectResourceUsage.Interval = 1000 * 60 ;
            timerCollectResourceUsage.Start();
        }

        protected override void OnStop()
        {
        }

        private void timerCollectResourceUsage_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            float cpuValue = CpuCounter.NextValue();
            float memoryValue = MemoryCounter.NextValue();

            InsertUsage(cpuValue, memoryValue);
        }

        public void GetResourceValue()
        {
            CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            MemoryCounter = new PerformanceCounter("Memory", "Available KBytes");

            float cpuValue = CpuCounter.NextValue();
            float memoryValue = MemoryCounter.NextValue();

            InsertUsage(cpuValue, memoryValue);
        }

        private static void InsertUsage(float cpuValue, float memoryValue)
        {
            using (
                var connection =
                    new System.Data.SqlClient.SqlConnection(
                        "Data Source=tcp:wintermocha.database.windows.net;Initial Catalog=ResourceUsage;Integrated Security=False;User ID=xodnxodn;Password=mocha8789!;Connect Timeout=15;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                )
            {
                connection.Open();

                using (var command = new System.Data.SqlClient.SqlCommand())
                {
                    SqlParameter param;
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = @"insert into RESOURCE_USAGE (CPU_USAGE ,	MEMORY_USAGE, PC_NAME)
                                            values(@cpu, @memory,@pcName);";

                    param = new SqlParameter("@cpu", SqlDbType.Int);
                    param.Value = cpuValue;
                    command.Parameters.Add(param);

                    param = new SqlParameter("@memory", SqlDbType.Int);
                    param.Value = memoryValue;
                    command.Parameters.Add(param);

                    param = new SqlParameter("@pcName", SqlDbType.VarChar, 50);
                    param.Value = "Live1";
                    command.Parameters.Add(param);

                    command.ExecuteScalar();
                }
            }
        }


    }
}
