using System.Data.SqlClient;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    public class SqlVariable
    {
        public static SqlConnection connection = new SqlConnection("Data Source=W11-VS2022;Initial Catalog=bts_mitarbeiterverwaltung;Integrated Security=True");
    }
}
