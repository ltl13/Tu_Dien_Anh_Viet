using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO {
    public class DataProvider {
        #region properties
        private static DataProvider instance;
        private static SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();


        public static DataProvider Instance {
            get {
                if (instance == null) {
                    instance = new DataProvider();
                    InitConnectionString();
                }
                return DataProvider.instance;
            }
            private set {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }
        #endregion

        #region method
        public static void InitConnectionString() {
            connectionString.DataSource = @".\SQLEXPRESS";
            connectionString.InitialCatalog = "DailyDictionary";
            connectionString.IntegratedSecurity = true;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null) {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara) {
                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null) {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara) {
                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null) {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara) {
                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        #endregion
    }
}
