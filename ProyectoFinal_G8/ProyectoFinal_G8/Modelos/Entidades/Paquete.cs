using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.Entidades
{
   public class Paquete
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Pesolibras { get; set; }
        public string Direccion { get; set; }
        public int Idcliente { get; set; }
        public int Telefonocliente { get; set; }

    }
}
