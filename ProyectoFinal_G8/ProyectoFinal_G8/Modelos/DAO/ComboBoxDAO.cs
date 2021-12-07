using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.DAO
{
    public class ComboBoxDAO : Conexion
    {
        private Conexion conectar = new Conexion();

        private SqlCommand comando = new SqlCommand();

        private SqlDataReader leer;

        public DataTable ListarCliente()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conectar.AbrirConexion();
            comando.CommandText = "SP_CARGARCOMBOBOXCLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conectar.CerrarConexion();
            return Tabla;
        }
    }
}
