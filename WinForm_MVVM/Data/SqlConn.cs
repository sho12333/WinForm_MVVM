using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SqlKata;

namespace WinForm_MVVM.Data
{
    public class SqlConn
    {
        public SqlConn()
        { }

        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        public static void OpenConnection(SqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void CloseConnection(SqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static void ExecuteNonQuery(SqlConnection conn, string query)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection conn, string query)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                return cmd.ExecuteReader();
            }
        }

        public static object ExecuteScalar(SqlConnection conn, string query)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                return cmd.ExecuteScalar();
            }
        }

        public static void ExecuteNonQuery(SqlConnection conn, string query, SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection conn, string query, SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteReader();
            }
        }

        public static object ExecuteScalar(SqlConnection conn, string query, SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public static void ExecuteNonQuery(SqlConnection conn, string query, SqlParameter parameter)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection conn, string query, SqlParameter parameter)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add(parameter);
                return cmd.ExecuteReader();
            }
        }

        public static object ExecuteScalar(SqlConnection conn, string query, SqlParameter parameter)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add(parameter);
                return cmd.ExecuteScalar();
            }
        }

        public static QueryFactory GetQueryFactory(SqlConnection connection)
        {
            var compiler = new SqlServerCompiler();

            return new QueryFactory(connection, compiler);
        }
    }
}