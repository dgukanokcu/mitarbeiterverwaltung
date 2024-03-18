using System.Data.SqlClient;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    public class SqlVariable
    {
        public static SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=bts_mitarbeiterverwaltung;Integrated Security=True");
    }
}
