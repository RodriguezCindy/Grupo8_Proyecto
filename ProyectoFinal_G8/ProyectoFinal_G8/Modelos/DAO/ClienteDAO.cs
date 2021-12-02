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
    public class ClienteDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool GuardarCliente(Cliente user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE ");
                sql.Append(" VALUES (@Nombre, @Email, @Telefono, @Direccion); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefono;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = user.Direccion;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return false;
            }
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
            }
            catch (Exception)
            {
            }
            return dat;
        }
    }
}
