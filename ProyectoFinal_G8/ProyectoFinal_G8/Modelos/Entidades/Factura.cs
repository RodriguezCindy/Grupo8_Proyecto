using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_G8.Modelos.Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public int NumeroPaquete { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdRepartidor { get; set; }

        public decimal Subtotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }
        public string Direccion { get; set; }
    }
}
