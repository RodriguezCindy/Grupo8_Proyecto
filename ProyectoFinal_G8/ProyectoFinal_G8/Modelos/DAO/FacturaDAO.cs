using ProyectoFinal_G8.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.DAO
{
    public class FacturaDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool GuardarFactura(Factura factura, List<DetalleFactura> detalleFactura)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO FACTURA ");
                sql.Append(" VALUES (@NumeroPaquete, @Fecha, @IdCliente, @IdRepartidor, @Subtotal, @Descuento, @ISV, @Total, @Direccion) ");
                sql.Append(" SELECT SCOPE_IDENTITY() ");
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
            catch (Exception e)
            {
                inserto = false;
            }
            return inserto;
        }
    }
}
