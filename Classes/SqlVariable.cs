using System.Data.SqlClient;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    public class SqlVariable
    {
        //DO
        public static SqlConnection connection = new SqlConnection("Data Source=PC-DO;Initial Catalog=bts_mitarbeiterverwaltung;Integrated Security=True");
    }
}
