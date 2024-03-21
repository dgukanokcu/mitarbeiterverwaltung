using System.Data.SqlClient;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    public class SqlVariable
    {
        /// <summary>
        /// Set the Sql connection string
        /// </summary>
        public static SqlConnection connection = new SqlConnection("Data Source=PC-DO;Initial Catalog=bts_mitarbeiterverwaltung;Integrated Security=True");
    }
}
