using System.Data.SqlClient;

namespace Model.Dao
{
    class Connection
    {
        private static Connection ObjConnection = null;
        private SqlConnection Con;

        private Connection()
        {
            Con = new SqlConnection("Data Source=.; Initial Catalog = Admin; Integrated Security = True");
        }
        public static Connection ConnectionState()
        {
            if (ObjConnection == null)
            {
                ObjConnection = new Connection();
            }
            return ObjConnection;
        }

        public SqlConnection GetCon()
        {
            return Con;
        }

        public void CloseConnection()
        {
            ObjConnection = null;
        }
    }
}
