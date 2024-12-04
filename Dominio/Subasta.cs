using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Subasta:Publicacion
    {
        public List<Oferta> ListaOfertas { get; set; }

        public Subasta(string nombre, List<Articulo> articulos) : base(nombre, articulos)
        {
            ListaOfertas = new List<Oferta>();
        }

        public override string ToString()
        {
            return $"Subasta: Id - {Id}, {Nombre}, {Estado}, {FechaPublicacion}";
        }

        public void AgregarOferta(Oferta f1) 
        {
            int posUltOf = ListaOfertas.Count; //Obtiene el largo der la lista de ofertas

            if (posUltOf == 0) //En caso de ser 0, agrega la oferta
            {
                ListaOfertas.Add(f1);
            }
            else
            {
                if (ListaOfertas[posUltOf - 1].Monto < f1.Monto) //Verifica que la oferta a agregar sea mayor a la ultima oferta realizada
                {
                    ListaOfertas.Add(f1);
                }
                else //En caso de no ser mayor, arroja una excepcion
                {
                    throw new Exception($"La oferta debe ser mejor a la ultima oferta ({ListaOfertas[posUltOf - 1].Monto})");
                }
            }
        }
        public override double ObtenerPrecio() //Obtiene el monto de la ultima oferta
        {

            if (ListaOfertas.Count != 0)
            {
                return ListaOfertas[ListaOfertas.Count - 1].Monto; 
            }
            else
            {
                return 0;
            }
        }


        public override void CerrarPublicacion(Usuario finalizador)
        {
            bool cerrada = false;
            if (finalizador is Administrador a && ListaOfertas.Count > 0) //Verifica que sea Administrador y que hayan ofertas
            {
                for (int i = ListaOfertas.Count - 1; i >= 0; i--)  //Recorre todas las ofertas
                {
                    var oferta = ListaOfertas[i];

                    if (oferta.Usuario.ObtenerSaldo() >= oferta.Monto) //Verifica que el usuario contenga el saldo que oferto
                    {
                        Estado = EstadoActual.CERRADA;
                        FechaCierre = DateTime.Now;
                        Comprador = oferta.Usuario;
                        UsuarioFinalizador = a;
                        Comprador.SaldoDisponible -= oferta.Monto;

                        cerrada = true; //Cierra la oferta
                    }
                }

                if (!cerrada) //Si ningun usuario cuenta con el monto ofertado se arroja una excepción
                {
                    this.Estado = EstadoActual.CANCELADA; // Cancela la subasta
                    throw new Exception("Nigun usuario cuenta con el dinero ofertado.");
                }
            }
            else //Si nadie oferto arroja una excepcion
            { throw new Exception("No hay ofertas para esta subasta."); }
        }

        
    }
}
