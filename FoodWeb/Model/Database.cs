using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;



namespace FoodWeb.Model
{

    public class Database
    {
       private SqlConnection connect;
        private SqlCommand command;
        public void Dispose()
        {
            if (connect != null)
            {
                connect.Dispose();
                connect = null;
            }
            if (command != null)
            {
                command.Dispose();
                command = null;
            }
        }

            public Database()
        {

            connect = new SqlConnection() { ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString };


        }
        public SqlDataReader MyExcuteReader(ref string err, string commandText, CommandType commandType, params SqlParameter[] param)
        {
           
            SqlDataReader datareader = null;
            try
            {

                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();

                command = new SqlCommand() { Connection = connect, CommandText = commandText, CommandType = commandType, CommandTimeout = 600 };
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        command.Parameters.Add(item);
                    }
                }
                datareader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return datareader;
        }
        public bool MyExcuteNonQuery(ref string err, ref int rows, string commandText, CommandType commandType, params SqlParameter[] param)
        {
            
            bool result = false;
            try
            {

                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();

                command = new SqlCommand() { Connection = connect, CommandText = commandText, CommandType = commandType, CommandTimeout = 600 };
                if (param != null)
                {
                    foreach (SqlParameter item in param)

                    {
                        command.Parameters.Add(item);
                    }
                }

                rows = command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                connect.Close();

            }
            return result;
        }
    }
}
