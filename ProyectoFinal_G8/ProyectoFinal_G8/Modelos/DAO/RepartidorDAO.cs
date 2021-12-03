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
    public class RepartidorDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool GuardarRepartidor(Repartidor user)
        {
            bool guardar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO REPARTIDOR ");
                sql.Append(" VALUES (@Dni, @Nombre, @Telefono) ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Dni", SqlDbType.NVarChar, 18).Value = user.Dni;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = user.Nombre;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefono;
                comando.ExecuteNonQuery();
                guardar = true;
                MiConexion.Close();
            }
            catch (Exception e)
            {
                guardar = false;
            }
            return guardar;
        }

        public bool EliminarRepartidor(int id)
        {
            bool eliminar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM REPARTIDOR ");
                sql.Append(" WHERE ID = @Id; ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                eliminar = true;
                MiConexion.Close();

            }
            catch (Exception)
            {
                return eliminar;
            }
            return eliminar;
        }

        public DataTable GetRepartidor()
        {
            DataTable dat = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append(" SELECT * FROM REPARTIDOR");
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
