using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Venta : Publicacion { 
    
        private static int _ultimoId = 0;
        public int Id { get; set; }
        public bool OfertaRelampago { get; set; }
        public Venta(string nombre, List<Articulo> articulos, bool ofertaRelampago) : base(nombre, articulos)
        {
            Id = _ultimoId++;
            OfertaRelampago = ofertaRelampago;
        }

        public override string ToString()
        {
            return $"Venta: Id - {Id}, {Nombre}, {Estado}, {FechaPublicacion}";
        }

      

        public override double ObtenerPrecio() //Recorre todos los articulos y calcula el precio dependiendo si esta en oferta
        {
            double precioFinal = 0;
            foreach (Articulo a in Articulos)
            {
                precioFinal += a.Precio;
            }
            if (OfertaRelampago) 
            {
                precioFinal = precioFinal* 0.8;
            }
           return precioFinal;
        }

        public override void CerrarPublicacion(Usuario u) 
        {
            if (u is Cliente c && c.SaldoDisponible >= ObtenerPrecio() && Estado == EstadoActual.ABIERTA) //Se fija si tiene saldo, es cliente y que se encuentre en estado abierto
            {
                Estado = EstadoActual.CERRADA;
                FechaCierre = DateTime.Now;
                Comprador = c;
                UsuarioFinalizador = u;

                c.SaldoDisponible -= ObtenerPrecio();
            }
            else { throw new Exception("Saldo insuficiente"); }
        }
    }
}
