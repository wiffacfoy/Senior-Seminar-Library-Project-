using System;
using Microsoft.Data.SqlClient; // Updated namespace for SqlCommand
using System.Windows.Forms;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        private static void UpdateBookDetails(SqlCommand cmd, string bname, string bauthor, string publication, DateTime pdate, decimal price, int quantity, int rowid)
        {
            cmd.CommandText = "UPDATE NewBook SET bName = @bName, bAuthor = @bAuthor, bPubl = @bPubl, bPDate = @bPDate, bPrice = @bPrice, bQuan = @bQuan WHERE bid = @bid";
            cmd.Parameters.AddWithValue("@bName", bname);
            cmd.Parameters.AddWithValue("@bAuthor", bauthor);
            cmd.Parameters.AddWithValue("@bPubl", publication);
            cmd.Parameters.AddWithValue("@bPDate", pdate);
            cmd.Parameters.AddWithValue("@bPrice", price);
            cmd.Parameters.AddWithValue("@bQuan", quantity);
            cmd.Parameters.AddWithValue("@bid", rowid);
        }
    }
}