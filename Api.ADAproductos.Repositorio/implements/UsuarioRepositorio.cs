using Api.ADAproductos.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Repositorio.implements
{
    public class UsuarioRepositorio:IUsuarioRepositorio
    {

        public async Task<string> Insertar(RolUsuario usuario)
        {

            string connectionString = "Data Source=DESKTOP-IIR56KK;Initial Catalog=ADA;";
            string insertQuery = "INSERT INTO rolusuario " +
                "(descripcion, " +
                "estado, " +
                "fecha_activacion, " +
                "fecha_modificacion, " +
                "fecha_inactivacion," +
                "usuario ) " +
                "VALUES (" +
                "@i_descripcion," +
                "@i_estado," +
                "@i_fecha_activacion," +
                "@i_fecha_modificacion," +
                "@i_fecha_inactivacion," +
                "@i_usuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("i_descripcion","");
                    insertCommand.Parameters.AddWithValue("@i_estado","");
                    insertCommand.Parameters.AddWithValue("@i_fecha_activacion","");
                    insertCommand.Parameters.AddWithValue("@i_fecha_modificacion","");
                    insertCommand.Parameters.AddWithValue("i_fecha_inactivacion","");
                    insertCommand.Parameters.AddWithValue("@i_usuario","");
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return "Registro insertado exitosamente.";
                    }
                    else
                    {
                        return "No se pudo insertar el registro.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error al insertar: " + ex.Message;
                }
            }

        } 
    }
}
    