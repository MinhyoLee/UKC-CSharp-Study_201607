using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace CpuSample
{
    class Program
    {

        static void Main(string[] args)
        {
            //PerformanceCounterCategory processorCategory = new PerformanceCounterCategory("Memory");
            //foreach (var c in processorCategory.GetCounters())
            //{
            //    Console.WriteLine(c.CounterName);
            //}

            PerformanceCounterCategory processorCategory = new PerformanceCounterCategory("Processor");

            PerformanceCounter[] counters = processorCategory.GetCounters("_Total");
            PerformanceCounter cpuCounter = counters.FirstOrDefault<PerformanceCounter>(p => p.CounterName.Equals("% Processor Time"));

            float cpu = cpuCounter.NextValue();

            for (int i = 0; i < 100; i++)
            {
                //OutputSample(cpuCounter.NextSample());
                cpu = cpuCounter.NextValue();
                InsertCpuUsage(cpu);
                Console.WriteLine(cpu);

                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
        private static void OutputSample(CounterSample s)
        {
            Console.WriteLine("\r\n+++++++++++");
            Console.WriteLine("Sample values - \r\n");
            Console.WriteLine("   BaseValue        = " + s.BaseValue);
            Console.WriteLine("   CounterFrequency = " + s.CounterFrequency);
            Console.WriteLine("   CounterTimeStamp = " + s.CounterTimeStamp);
            Console.WriteLine("   CounterType      = " + s.CounterType);
            Console.WriteLine("   RawValue         = " + s.RawValue);
            Console.WriteLine("   SystemFrequency  = " + s.SystemFrequency);
            Console.WriteLine("   TimeStamp        = " + s.TimeStamp);
            Console.WriteLine("   TimeStamp100nSec = " + s.TimeStamp100nSec);
        }

        private static void InsertCpuUsage(float cpu)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection("Data Source=tcp:wintermocha.database.windows.net;Initial Catalog=ResourceUsage;Integrated Security=False;User ID=xodnxodn;Password=mocha8789!;Connect Timeout=15;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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
                    param.Value = cpu;
                    command.Parameters.Add(param);

                    param = new SqlParameter("@memory", SqlDbType.Int);
                    param.Value = cpu;
                    command.Parameters.Add(param);

                    param = new SqlParameter("@pcName", SqlDbType.VarChar,50);
                    param.Value = "Live1";
                    command.Parameters.Add(param);

                    command.ExecuteScalar();
                    //command.ExecuteReader();
                }
            }
        }
    }

    class CpuInfo
    {
        float CpuUsage { get; set; }
        float MemoryUsage { get; set; }
        DateTime ResourceCheckTime { get; set; }
        string PcName { get; set; }
    }
}