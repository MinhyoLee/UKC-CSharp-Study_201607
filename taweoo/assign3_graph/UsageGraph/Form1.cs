using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsageGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetUsageData();
        }

        private void GetUsageData()
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
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = @"SELECT T.TIME, AVG(T.CPU_USAGE) as CPU_USAGE ,AVG( T.MEMORY_USAGE) as MEMORY_USAGE
                                            FROM 
                                            (
                                            SELECT CONVERT (varchar,TIME,8) AS TIME , CPU_USAGE , MEMORY_USAGE
                                            FROM RESOURCE_USAGE
                                            ) T 	 
                                            GROUP BY T.TIME";

                    //var reader = command.ExecuteReader();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    chtResource.DataSource = ds;
                }
            }
        }
    }
}
