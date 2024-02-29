using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    public class SqlVariable
    {
        public static SqlConnection connection = new SqlConnection("Data Source=W11-VS2022;Initial Catalog=bts_mitarbeiterverwaltung;Integrated Security=True");
    }
}
