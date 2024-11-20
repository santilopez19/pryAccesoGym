using Microsoft.Data.SqlClient; 
using System;
using System.Data;
using static LinqToDB.Reflection.Methods.LinqToDB;
using System.Net;

namespace pryAccesoGym
{
    internal class bdGimnasio
    {
        public static class DatabaseHelper
        {
           /* -- Inserción de clientes
INSERT INTO Clientes(DNI, Nombre, Apellido, Sexo, FechaNacimiento, FechaIngreso)
VALUES
('12345678', 'Juan', 'Pérez', 'M', '1990-05-15', '2023-01-10'),
('23456789', 'Ana', 'Gómez', 'F', '1995-08-20', '2023-06-22'),
('34567890', 'Carlos', 'López', 'M', '1988-11-12', '2023-03-18'),
('45678901', 'Lucía', 'Martínez', 'F', '1992-03-10', '2023-11-01'); 
            INSERT INTO Pagos(DNI, FechaPago, Monto, MetodoPago)
VALUES
('12345678', '2023-10-01', 1500.00, 'Efectivo'),
('23456789', '2023-10-15', 1200.00, 'Tarjeta'),
('34567890', '2023-09-10', 1000.00, 'Transferencia'),
('45678901', '2023-10-20', 1300.00, 'Efectivo'); */
            // Cadena de conexión
            private static readonly string connectionString = "server=localhost; database=dbGimnasio; integrated security=true; Encrypt=False;";

            public static object ExecuteScalar(string query, SqlParameter[] parameters)
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
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
