using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RG_Tickets
{
    class Conexão
    {
        private static string server = @"DESKTOP-GJR9QG2\SQLEXPRESS";
        private static string database = "Rg_tickets";
        private static string user = @"DESKTOP-GJR9QG2\Guto Andrade";
        private static string pwd = "";
    public static string StrConn
        {
            get { return $"Data Source={server} ; Integrated Security= true; Initial Catalog={database}; User ID={user}; password={pwd}";}
        }
            


    }







    



    

}
