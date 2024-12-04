using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Publicacion:IComparable<Publicacion>
    {
        private static int _ultimoId = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public EstadoActual Estado { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public List<Articulo> Articulos { get; set; }
        public DateTime? FechaCierre { get; set; }
        public Cliente Comprador { get; set; }
        public Usuario UsuarioFinalizador { get; set; }

        public enum EstadoActual
        {
            ABIERTA,
            CERRADA,
            CANCELADA
        }

        protected Publicacion(string nombre, List<Articulo> articulos)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Estado = EstadoActual.ABIERTA;
            FechaPublicacion = DateTime.Now;
            Articulos = articulos;
            Comprador = null;
        }

        protected Publicacion()
        {
            Id = _ultimoId++;
        }
        public void Validar()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre no puede ser vacio");
            }

        }
        public abstract void CerrarPublicacion(Usuario finalizador);

        public abstract double ObtenerPrecio();

        public int CompareTo(Publicacion? other)
        {
            if (FechaPublicacion.CompareTo(other.FechaPublicacion) > 0){
                return 1;
            }else if(FechaPublicacion.CompareTo(other.FechaPublicacion) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
