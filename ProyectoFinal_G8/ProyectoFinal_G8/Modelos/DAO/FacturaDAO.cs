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
    class FacturaDAO : Conexion
    {

        SqlCommand comando = new SqlCommand();
        public bool GuardarFactura(Factura user)
        {
            bool guardar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO FACTURA ");
                sql.Append(" VALUES (@IDFactura, @IDCliente, @IDRepartidor, @NumPaquete, @Fecha, @Direccion, @Subtotal, @Descuento, @ISV, @Total) ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IDFactura", SqlDbType.Int).Value = user.IDFactura;
                comando.Parameters.Add("@IDCliente", SqlDbType.NVarChar, 50).Value = user.IDCliente;
                comando.Parameters.Add("@IDRepartidor", SqlDbType.Int).Value = user.IDRepartidor;
                comando.Parameters.Add("@NumPaquete", SqlDbType.Int).Value = user.NumPaquete;
                comando.Parameters.Add("@Fecha", SqlDbType.Int).Value = user.Fecha;
                comando.Parameters.Add("@Direccion", SqlDbType.Int).Value = user.Direccion;
                comando.Parameters.Add("@Subtotal", SqlDbType.Int).Value = user.Subtotal;
                comando.Parameters.Add("@Descuento", SqlDbType.Int).Value = user.Descuento;
                comando.Parameters.Add("@ISV", SqlDbType.Int).Value = user.ISV;
                comando.Parameters.Add("@Total", SqlDbType.Int).Value = user.Total;
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

        public bool EliminarFactura(int id)
        {
            bool eliminar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM FACTURA ");
                sql.Append(" WHERE ID = @Id; ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IDFactura", SqlDbType.Int).Value = id;
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

        public DataTable GetFactura()
        {
            DataTable dat = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append(" SELECT * FROM FACTURA");
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
