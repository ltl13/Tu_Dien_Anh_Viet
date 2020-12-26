using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        public void SaveImage(int userID, byte[] data) {
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString)) {
                connection.Open();
                using (SqlCommand cm = new SqlCommand("USP_SaveImage", connection)) {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, ParameterDirection.InputOutput, false, 10, 0, "Id", DataRowVersion.Current, (SqlInt32)userID));

                    if (data.Length > 0) {
                        cm.Parameters.Add(new SqlParameter("@Data", SqlDbType.VarBinary, data.Length, ParameterDirection.Input, false, 0, 0, "Data", DataRowVersion.Current, (SqlBinary)data));
                    }
                    else {
                        cm.Parameters.Add(new SqlParameter("@Data", SqlDbType.VarBinary, 0, ParameterDirection.Input, false, 0, 0, "Data", DataRowVersion.Current, DBNull.Value));
                    }

                    cm.ExecuteNonQuery();
                }
            }
        }

        public byte[] LoadImage(int userID) {
            byte[] image;

            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString)) {
                connection.Open();
                string query = "SELECT PictureData FROM dbo.Picture WHERE ID = " + userID;

                using (SqlCommand cm = new SqlCommand(query, connection)) {
                    image = (byte[])cm.ExecuteScalar();
                }
            }

            return image;
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
