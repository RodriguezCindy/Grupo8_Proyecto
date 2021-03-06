using ProyectoFinal_G8.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.DAO
{
    public class ClienteDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool GuardarCliente(Cliente user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE ");
                sql.Append(" VALUES (@Nombre, @Email, @Telefono, @Direccion) ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefono;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = user.Direccion;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
            }
            catch (Exception )
            {
                inserto = false;
            }
            return inserto;
        }

        public bool EliminarCliente(int id)
        {
            bool eliminar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE ");
                sql.Append(" WHERE ID = @Id; ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                eliminar  = true;
                MiConexion.Close();

            }
            catch (Exception)
            {
                return eliminar;
            }
            return eliminar;
        }

        public DataTable GetUsuario()
        {
            DataTable dat = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append(" SELECT * FROM CLIENTE");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dat.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dat;
        }
    }
}
