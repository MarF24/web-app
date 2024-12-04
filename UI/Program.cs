using Dominio;
using System.Net.Http.Headers;
using static Dominio.Articulo;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema s = new Sistema(); // init sistema con precarga incluida

            int op = -1; // valor default del menu while

            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Listar Usuarios");
                Console.WriteLine("2-Dado un nombre de categoría listar todos los artículos de esa categoría.");
                Console.WriteLine("3-Dar de alta a un articulo");
                Console.WriteLine("4- Publicaciones entre dos fechas");

                try
                {
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        //Recorre la lista de usuarios y muestra en pantalla sus nombres
                        foreach (Usuario U in s.GetUsuarios())
                        {
                            Console.WriteLine(U.ToString());
                        }
                        Console.ReadKey();

                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Seleccione una categoria");
                        int opCat = 0;

                        //Recorre los tipos de categoria y los muestra en pantalla con su respectivo "indice"
                        foreach (CategoriaArticulo cat in Enum.GetValues(typeof(CategoriaArticulo)))
                        {
                            Console.WriteLine($"{((int)cat)}-{cat.ToString()}");
                        }

                        //Setea la op de usuario
                        opCat = int.Parse(Console.ReadLine());

                        // Recorre todos los articulos en el sistema e imprime los que pertenezcan a la cat
                        if (s.ObtenerArticulosCat((CategoriaArticulo)opCat).Count == 0)
                        {
                            Console.WriteLine("No hay articulos de esa categoria");
                        }
                        else
                        {
                            foreach (Articulo ar in s.ObtenerArticulosCat((CategoriaArticulo)opCat))
                            {
                                Console.WriteLine($"{ar.Nombre} - ${ar.Precio}");
                            }
                        }

                        //Console.WriteLine((CategoriaArticulo)opCat);
                        Console.ReadKey();
                    }
                    else if (op == 3)
                    {
                        Console.Clear();

                        int opCat = 0;
                        double precioArticulo = 0;
                        string nombreArticulo = string.Empty;

                        Console.WriteLine("Seleccione le categoria de su articulo");

                        //Recorre los tipos de categoria y los muestra en pantalla con su respectivo "indice"
                        foreach (CategoriaArticulo cat in Enum.GetValues(typeof(CategoriaArticulo)))
                        {
                            Console.WriteLine($"{((int)cat)}-{cat.ToString()}");
                        }

                        opCat = int.Parse(Console.ReadLine()); //Setea la op de usuario
                        if (opCat > 5 || opCat < 0)
                        {
                            throw new Exception("No existe esa categoria");
                        }
                        CategoriaArticulo categoriaSeleccionada = (CategoriaArticulo)opCat; //obtiene la categoria



                        Console.WriteLine("Ingrese nombre del articulo");
                        nombreArticulo = Console.ReadLine();
                        Console.WriteLine("Precio del articulo");
                        precioArticulo = int.Parse(Console.ReadLine());

                        //Crea el articulo
                        Articulo nuevoArticulo = new Articulo(nombreArticulo, precioArticulo, categoriaSeleccionada);

                        s.AltaArticulo(nuevoArticulo);
                        Console.WriteLine("Articulo agregado");

                        Console.ReadKey();
                    }
                    else if (op == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese la primer fecha (Y/M/D)");
                        DateTime f1 = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda fecha (Y/M/D)");
                        DateTime f2 = DateTime.Parse(Console.ReadLine());
                        List<Publicacion> ListaPub = s.GetPublicacionesDosFechas(f1, f2);
                        if (ListaPub.Count > 0)
                        {
                            foreach (Publicacion p in ListaPub)
                            {

                                Console.WriteLine(p.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay publicaciones entre esas fechas");
                        }

                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
