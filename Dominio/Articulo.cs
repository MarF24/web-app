using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        private static int _ultimoId = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CategoriaArticulo Categoria { get; set; }

        public double Precio { get; set; }


        //CONSTRUCOTR
        public Articulo(string nombre, double precio, CategoriaArticulo categoria)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        //TIPOS DE CATEGORIAS
        public enum CategoriaArticulo
        {
            Electronicos,
            Ropa,
            Alimentos,
            Hogar,
            Juguetes,
            Otros
        }


        //METODO PARA VAILDAR

        public void Validar()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre no puede ser vacio");
            }

            if (Precio <= 0)
            {
                throw new Exception("El precio debe ser mayor a 0");
            }

            if (Categoria != CategoriaArticulo.Electronicos &&
                    Categoria != CategoriaArticulo.Juguetes &&
                    Categoria != CategoriaArticulo.Ropa &&
                    Categoria != CategoriaArticulo.Alimentos &&
                    Categoria != CategoriaArticulo.Hogar &&
                    Categoria != CategoriaArticulo.Otros)
                            {
                throw new Exception("Categoria invalida");
            }
        }
    }
}
