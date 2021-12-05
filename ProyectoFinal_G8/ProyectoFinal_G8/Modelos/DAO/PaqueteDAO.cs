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
    class PaqueteDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool GuardarPaquete(Paquete user)
        {
            bool guardar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO PAQUETE ");
                sql.Append(" VALUES (@Nombre, @Email, @Telefono, @Departamento, @Ciudad, @Direccion, @Peso) ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.Int).Value = user.Nombre_Desti;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefono;
                comando.Parameters.Add("@Departamento", SqlDbType.Int).Value = user.Departamento;
                comando.Parameters.Add("@Ciudad", SqlDbType.Int).Value = user.Ciudad;
                comando.Parameters.Add("@Direccion", SqlDbType.Int).Value = user.Direccion;
                comando.Parameters.Add("@Peso", SqlDbType.Int).Value = user.Peso;
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
                sql.Append(" WHERE ID = @ID; ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = id;
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
