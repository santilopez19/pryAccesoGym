﻿using Microsoft.Data.SqlClient; // Asegúrate de usar esta biblioteca
using System;
using System.Data;

namespace pryAccesoGym
{
    internal class bdGimnasio
    {
        public static class DatabaseHelper
        {
            // Cadena de conexión
            private static readonly string connectionString = "server=localhost; database=dbGimnasio; integrated security=true; Encrypt=False;";

            public static object ExecuteScalar(string query, SqlParameter[] parameters)
            {
                using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        connection.Open();
                        return command.ExecuteScalar();
                    }
                }
            }
            public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            if (parameters != null)
                            {
                                command.Parameters.AddRange(parameters);
                            }

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error ejecutando la consulta: " + ex.Message);
                }

                return dataTable;
            }

            public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            if (parameters != null)
                            {
                                command.Parameters.AddRange(parameters);
                            }

                            return command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el comando: " + ex.Message);
                }
            }
        }
    }
}
