using System;

namespace e_wallet
{
	/// <summary>
	/// Config�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Config : System.Windows.Forms.Form
	{
		// DB
		public string connString = @"Provider=Microsoft.Jet.OLEDB.4.0 ; Data Source = ./Data/WalletDB.mdb; Jet OLEDB:Database Password=";
		// ���� ���� 
		public string excelconn=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=business_date.xls;Extended Properties=""Excel 8.0;HDR=YES""" ;
		
		public Config() {}		
	}
}
