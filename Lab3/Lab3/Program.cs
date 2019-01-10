using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    /*AUTHOR: NICHOLAS SIM
      DATE: 01-09-2019
      CLASS: CPG200
      OBJECTIVE: Create a program that reads database and provides detailed information on products.
    */
    static class Program
    {
        public static string ConnectionString;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(); //Creates a SqlConnectionStringBuilder 
            builder["Server"] = "LOCALHOST\\SQLEXPRESS";
            builder["Integrated Security"] = "SSPI";
            builder["Database"] = "Northwind";
            ConnectionString = builder.ConnectionString; //Builds a functional connection on Micheals computer. Fingers Crossed.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
