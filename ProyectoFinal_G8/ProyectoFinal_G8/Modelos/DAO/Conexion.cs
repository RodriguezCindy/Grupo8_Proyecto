using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.DAO
{
     public class Conexion
    {
        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ProyectoConexion"].ConnectionString);
        public SqlConnection AbrirConexion()
        {
            if (MiConexion.State == ConnectionState.Closed)
                MiConexion.Open();
            return MiConexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (MiConexion.State == ConnectionState.Open)
                MiConexion.Close();
            return MiConexion;
        }
    }
}
