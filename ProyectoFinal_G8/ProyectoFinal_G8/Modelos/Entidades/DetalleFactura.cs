using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.Entidades
{
    public  class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdRepartidor { get; set; }
        public int IdCliente { get; set; }
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
    }
}
