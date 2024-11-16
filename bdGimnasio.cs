using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pryAccesoGym
{
    internal class bdGimnasio
    {

        public static class DatabaseHelper
        {
            // Cadena de conexión
            private static readonly string connectionString = "server=localhost; database=dbGimnasio; integrated security=true; Encrypt=False;";

            /// <summary>
            /// Ejecuta una consulta SELECT y devuelve los resultados en un DataTable.
            /// </summary>
            /// <param name="query">Consulta SQL a ejecutar.</param>
            /// <returns>DataTable con los resultados de la consulta.</returns>
            public static DataTable ExecuteQuery(string query)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar la consulta: " + ex.Message);
                }

                return dataTable;
            }

            /// <summary>
            /// Ejecuta un comando SQL no relacionado con consultas SELECT (INSERT, UPDATE, DELETE).
            /// </summary>
            /// <param name="query">Consulta SQL a ejecutar.</param>
            /// <param name="parameters">Parámetros para la consulta SQL.</param>
            /// <returns>Número de filas afectadas.</returns>
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

