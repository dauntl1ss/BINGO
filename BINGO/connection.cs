using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BINGO
{
    class connection
    {
        public static SqlConnection conn;
        private static String dbconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\BINGO FINAL\\BINGO\\BINGO\\BINGODatabase.mdf;Integrated Security=True";


        public static void DB()
        {
            try
            {
                conn = new SqlConnection(dbconnect);
                conn.Open();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }
}
