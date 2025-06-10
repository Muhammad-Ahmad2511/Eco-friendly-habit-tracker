using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;   
namespace WindowsFormsApp2
{
    class DBAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlTransaction DbTran;

        public static string strConnString = "Data Source=MY-PC-13;Initial Catalog=eco;Integrated Security=True";
        public void createConn()
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.ConnectionString = strConnString;
                connection.Open();
            }

        }
        public void closeConn()
        {
            connection.Close();
        }

        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {

            if (connection.State == 0)
            {
                createConn();
            }

            adapter.SelectCommand.CommandText = strSelectSql;
            adapter.SelectCommand.CommandType = CommandType.Text;
            SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);


            string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
            string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
            string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();


            return adapter.Update(tblName);

        }

        public void readDatathroughAdapter(string query, DataTable tblName, Dictionary<string, object> parameters = null)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(tblName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    closeConn();
                }
            }
        }

        public SqlDataReader readDatathroughReader(string query, Dictionary<string, object> parameters = null)
        {
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    // Add parameters to the command
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    // Execute the reader
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return reader;
        }
        public SqlDataReader readDatathroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source
            SqlDataReader reader;

            if (connection.State == ConnectionState.Closed)
            {
                createConn();
            }

            command.Connection = connection;
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            reader = command.ExecuteReader();
            return reader;

        }


        public int executeQuery(SqlCommand dbCommand)
        {
            if (connection.State == 0)
            {
                createConn();
            }

            dbCommand.Connection = connection;
            dbCommand.CommandType = CommandType.Text;


            return dbCommand.ExecuteNonQuery();
        }
        public bool CheckEmailExists(string email)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email";

            if (connection.State == ConnectionState.Closed)
            {
                createConn();
            }

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }

            return exists;
        }
        public bool CheckPassword(string email, string password)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND Password = @Password";
            bool isValid = false;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int result = (int)command.ExecuteScalar();
                    isValid = result == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    closeConn();
                }
            }

            return isValid;
        }
        public string GetUsername(string email)
        {
            string query = "SELECT name FROM Users WHERE Email = @Email";
            string username = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        username = reader["name"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    closeConn();
                }
            }

            return username;
        }
        public void SaveImage(string email, byte[] imageBytes)
        {
            string query = @"
        IF EXISTS (SELECT 1 FROM image WHERE email = @Email)
        BEGIN
            UPDATE image SET image_data = @Image WHERE email = @Email
        END
        ELSE
        BEGIN
            INSERT INTO image (email, image_data) VALUES (@Email, @Image)
        END";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Image", imageBytes);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    closeConn();
                }
            }
        }
        public byte[] GetImage(string email)
        {
            string query = "SELECT image_data FROM image WHERE email = @Email";
            byte[] imageBytes = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("image_data")))
                    {
                        imageBytes = reader["image_data"] as byte[];
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    closeConn();
                }
            }

            return imageBytes;
        }
        public void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    closeConn();
                }
            }
        }
    }
}

