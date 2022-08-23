using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class sqlVariables //classların ilk harfi büyük olur method isim büyük
    {
        
        public static SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=kisiler;Integrated Security=True");

        public static void checkConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == System.Data.ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {

            }
        }

       
    }
}
