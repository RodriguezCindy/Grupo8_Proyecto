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
    public class FacturaDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool GuardarFactura(Factura user)
        {
            bool guardar = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO FACTURA ");
                sql.Append(" VALUES ( @Idcliente, @NumPaquete, @Fecha, @Direccion, @Subtotal, @Total) ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Idcliente", SqlDbType.Int).Value = user.IdCliente;
                comando.Parameters.Add("@NumPaquete", SqlDbType.Int).Value = user.NumeroPaquete;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = user.Fecha;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = user.Direccion;
                comando.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = user.Subtotal;
                comando.Parameters.Add("@Total", SqlDbType.Decimal).Value = user.Total;
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
