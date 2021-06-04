using Microsoft.Data.SqlClient;
using System;

namespace Lab18
{
    class Program
    {
        public static string ConnStr = @"Data Source=DESKTOP-FJ25DCG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
        //    Console.WriteLine("Hello World!");

            SqlConnection cn = new SqlConnection(ConnStr);
            SqlCommand cmd;
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Guy] VALUES('Makar', 'Makarov', '28')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Cars] VALUES('Porche 911')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Banks] VALUES (150000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Works] VALUES('Game Developer')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Hobbies] VALUES('Computer Games')";
            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}
