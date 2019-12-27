using System.Data;
using System.Data.SqlClient;

namespace SiparisOtomasyonSistemi.UI
{
    public class ConnectionDal
    {
        private static SqlConnection ConnectionDatabase()
        {
            return new SqlConnection(@"Data Source=.;initial catalog=SiparisOtomasyonDb;integrated security=true;");
        }

        public static DataTable ExecuteDataTable(string sqlstring, SqlParameter[] dataParameters = null, CommandType type = CommandType.Text)
        {
            using (SqlConnection connection = ConnectionDatabase())
            {
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                cmd.CommandType = type;
                if (dataParameters != null)
                    cmd.Parameters.AddRange(dataParameters);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static int ExecuteNonQuery(string sqlString, SqlParameter[] datapParameters = null, CommandType type = CommandType.Text)
        {
            using (SqlConnection connection = ConnectionDatabase())
            {
                SqlCommand command = new SqlCommand(sqlString, connection);
                command.CommandType = type;
                if (datapParameters != null)
                    command.Parameters.AddRange(datapParameters);
                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    return command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                }
            }
        }
        public static object ExecuteScalar(string sqlString, SqlParameter[] datapParameters = null, CommandType type = CommandType.Text)
        {
            using (SqlConnection connection = ConnectionDatabase())
            {
                SqlCommand command = new SqlCommand(sqlString, connection);
                command.CommandType = type;
                if (datapParameters != null)
                    command.Parameters.AddRange(datapParameters);
                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    return command.ExecuteScalar();
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                }
            }
        }
    }
}