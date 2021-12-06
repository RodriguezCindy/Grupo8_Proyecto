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
   public class PaqueteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool GuardarPaquete(Paquete user)
        {
            bool guardar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO PAQUETE ");
                sql.Append(" VALUES (@Descipcion, @Idcliente, @Direccion, @Telefono, @Peso) ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Descipcion", SqlDbType.NVarChar, 100).Value = user.Descripcion;
                comando.Parameters.Add("@Idcliente", SqlDbType.Int).Value = user.Idcliente;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = user.Direccion;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefonocliente;
                comando.Parameters.Add("@Peso", SqlDbType.Decimal).Value = user.Pesolibras;
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

        public bool EliminarPaquete(int id)
        {
            bool eliminar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM PAQUETE ");
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

        public DataTable GetPaquete()
        {
            DataTable dat = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append(" SELECT * FROM PAQUETE");
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

