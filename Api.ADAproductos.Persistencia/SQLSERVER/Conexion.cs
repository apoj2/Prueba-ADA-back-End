using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Persistencia.SQLSERVER
{
    public class Conexion
    {
        public string connectionString = "NombreDeTuConexion";

        private readonly SqlConnection _connection;

        public Conexion(SqlConnection connection) 
        { 
            _connection = connection;
        }

        public string IniciarConexion()
        {
 
            try
            {
                _connection.Open();
                return "Conexión exitosa a SQL Server.";
                // Realiza operaciones en la base de datos aquí
            }
            catch (Exception ex)
            {
                return"Error al conectar a SQL Server: " + ex.Message;
            }
        
        }

    }
}
