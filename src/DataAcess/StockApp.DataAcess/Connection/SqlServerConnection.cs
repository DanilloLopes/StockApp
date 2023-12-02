using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Connection
{ 

    internal static class SqlServerConnection
    {
        internal static string ConexaoSemBanco => @"Data Source=.\SQLEXPRESS;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
        internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=STOCKELETRO;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
    }

}