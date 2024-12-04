using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Articulo;
using static Dominio.Publicacion;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema instancia = null;

        List<Usuario> _usuarios = new List<Usuario>();
        List<Publicacion> _publicaciones = new List<Publicacion>();
        List<Articulo> _articulos = new List<Articulo>();
        List<Cliente> _clientes = new List<Cliente>();
        List<Administrador> _administradores = new List<Administrador>();

        public List<Usuario> GetUsuarios() { return _usuarios; }
        public List<Publicacion> GetPublicaciones() { return _publicaciones; }
        public List<Articulo> GetArticulos() { return _articulos; }
        public List<Cliente> GetClientes() { return _clientes; }
        public List<Administrador> GetAdmins() { return _administradores; }

        public Sistema()
        {
            Precarga();
        }

        public static Sistema GetInstancia()
        {

            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }

        private void Precarga()
        {
            Usuario test = new Cliente("a", "a", "a", "a", 6500);
            Usuario test1 = new Administrador("b", "b", "b", "b");

            AltaUsuario(test);
            AltaUsuario(test1);


            Usuario c1 = new Cliente("Juan", "Perez", "jp@gmail.com", "12345", 1500);
            Usuario c2 = new Cliente("Ana", "Perez", "ap@gmail.com", "67890", 2500);
            Usuario c3 = new Cliente("Ronaldo", "Nazario", "R9@gmail.com", "goat", 99999);
            Usuario a1 = new Administrador("Maria", "Rodriguez", "mr@gmail.com", "45621");
            Usuario a2 = new Administrador("Cristiano", "Ronaldo", "cr7@gmail.com", "mrchampions");

            //Usuarios
            AltaUsuario(c1);
            AltaUsuario(c2);
            AltaUsuario(c3);
            //Admins
            AltaUsuario(a1);
            AltaUsuario(a2);

            //////////////////////////////////////////////////////////////
            ///

            Articulo articulo1 = new Articulo("Pelota", 350, CategoriaArticulo.Juguetes);
            Articulo articulo2 = new Articulo("Muñeco", 123, CategoriaArticulo.Juguetes);
            Articulo articulo3 = new Articulo("Calefon", 2500, CategoriaArticulo.Hogar);

            ////////////////////////////////////////
            ///


            //ARTICULOS PRECARGADOS
            // Electrónicos
            Articulo articulo4 = new Articulo("Smartphone", 70000, CategoriaArticulo.Electronicos);
            Articulo articulo5 = new Articulo("Televisor", 30000, CategoriaArticulo.Electronicos);
            Articulo articulo6 = new Articulo("Tablet", 25000, CategoriaArticulo.Electronicos);
            Articulo articulo7 = new Articulo("Altavoz Bluetooth", 3000, CategoriaArticulo.Electronicos);
            Articulo articulo8 = new Articulo("Cargador portátil", 1500, CategoriaArticulo.Electronicos);

            // Ropa
            Articulo articulo9 = new Articulo("Camiseta", 500, CategoriaArticulo.Ropa);
            Articulo articulo10 = new Articulo("Pantalones", 1200, CategoriaArticulo.Ropa);
            Articulo articulo11 = new Articulo("Chaqueta", 2500, CategoriaArticulo.Ropa);
            Articulo articulo12 = new Articulo("Zapatos", 3000, CategoriaArticulo.Ropa);
            Articulo articulo13 = new Articulo("Sombrero", 800, CategoriaArticulo.Ropa);

            // Alimentos
            Articulo articulo14 = new Articulo("Arroz", 200, CategoriaArticulo.Alimentos);
            Articulo articulo15 = new Articulo("Frijoles", 250, CategoriaArticulo.Alimentos);
            Articulo articulo16 = new Articulo("Azúcar", 150, CategoriaArticulo.Alimentos);
            Articulo articulo17 = new Articulo("Aceite", 800, CategoriaArticulo.Alimentos);
            Articulo articulo18 = new Articulo("Leche", 500, CategoriaArticulo.Alimentos);

            // Hogar
            Articulo articulo19 = new Articulo("Cojín", 600, CategoriaArticulo.Hogar);
            Articulo articulo20 = new Articulo("Cortina", 900, CategoriaArticulo.Hogar);
            Articulo articulo21 = new Articulo("Mantel", 400, CategoriaArticulo.Hogar);
            Articulo articulo22 = new Articulo("Candelabro", 1000, CategoriaArticulo.Hogar);
            Articulo articulo23 = new Articulo("Espejo decorativo", 1500, CategoriaArticulo.Hogar);

            // Juguetes
            Articulo articulo24 = new Articulo("Construcciones LEGO", 800, CategoriaArticulo.Juguetes);
            Articulo articulo25 = new Articulo("Puzzles", 600, CategoriaArticulo.Juguetes);
            Articulo articulo26 = new Articulo("Triciclo", 1200, CategoriaArticulo.Juguetes);
            Articulo articulo27 = new Articulo("Juego de cartas", 300, CategoriaArticulo.Juguetes);
            Articulo articulo28 = new Articulo("Dinosaurio de juguete", 450, CategoriaArticulo.Juguetes);

            // Otros
            Articulo articulo29 = new Articulo("Agenda", 400, CategoriaArticulo.Otros);
            Articulo articulo30 = new Articulo("Batería", 1500, CategoriaArticulo.Otros);
            Articulo articulo31 = new Articulo("Herramienta multifuncional", 2000, CategoriaArticulo.Otros);
            Articulo articulo32 = new Articulo("Mochila", 700, CategoriaArticulo.Otros);
            Articulo articulo33 = new Articulo("Cámara instantánea", 3500, CategoriaArticulo.Otros);

            // Más artículos
            Articulo articulo34 = new Articulo("Bolígrafo", 100, CategoriaArticulo.Otros);
            Articulo articulo35 = new Articulo("Reloj de pulsera", 2500, CategoriaArticulo.Otros);
            Articulo articulo36 = new Articulo("Tijeras de oficina", 200, CategoriaArticulo.Otros);
            Articulo articulo37 = new Articulo("Silla de escritorio", 1800, CategoriaArticulo.Otros);
            Articulo articulo38 = new Articulo("Papel para fotocopia", 250, CategoriaArticulo.Otros);

            // Ropa
            Articulo articulo39 = new Articulo("Sudadera", 1500, CategoriaArticulo.Ropa);
            Articulo articulo40 = new Articulo("Medias", 300, CategoriaArticulo.Ropa);
            Articulo articulo41 = new Articulo("Pijamas", 800, CategoriaArticulo.Ropa);
            Articulo articulo42 = new Articulo("Bufanda", 400, CategoriaArticulo.Ropa);
            Articulo articulo43 = new Articulo("Guantes", 500, CategoriaArticulo.Ropa);

            // Electrónicos
            Articulo articulo44 = new Articulo("Reproductor de música", 3500, CategoriaArticulo.Electronicos);
            Articulo articulo45 = new Articulo("Smartwatch", 12000, CategoriaArticulo.Electronicos);
            Articulo articulo46 = new Articulo("Proyector", 50000, CategoriaArticulo.Electronicos);
            Articulo articulo47 = new Articulo("Cámara de seguridad", 15000, CategoriaArticulo.Electronicos);
            Articulo articulo48 = new Articulo("Microondas", 8000, CategoriaArticulo.Electronicos);
            Articulo articulo49 = new Articulo("Cafetera", 3000, CategoriaArticulo.Electronicos);
            Articulo articulo50 = new Articulo("Batidora", 2000, CategoriaArticulo.Electronicos);

            /////////////////////////
            //Articulos
            AltaArticulo(articulo1);
            AltaArticulo(articulo2);
            AltaArticulo(articulo3);
            AltaArticulo(articulo4);
            AltaArticulo(articulo5);
            AltaArticulo(articulo6);
            AltaArticulo(articulo7);
            AltaArticulo(articulo8);
            AltaArticulo(articulo9);
            AltaArticulo(articulo10);
            AltaArticulo(articulo11);
            AltaArticulo(articulo12);
            AltaArticulo(articulo13);
            AltaArticulo(articulo14);
            AltaArticulo(articulo15);
            AltaArticulo(articulo16);
            AltaArticulo(articulo17);
            AltaArticulo(articulo18);
            AltaArticulo(articulo19);
            AltaArticulo(articulo20);
            AltaArticulo(articulo21);
            AltaArticulo(articulo22);
            AltaArticulo(articulo23);
            AltaArticulo(articulo24);
            AltaArticulo(articulo25);
            AltaArticulo(articulo26);
            AltaArticulo(articulo27);
            AltaArticulo(articulo28);
            AltaArticulo(articulo29);
            AltaArticulo(articulo30);
            AltaArticulo(articulo31);
            AltaArticulo(articulo32);
            AltaArticulo(articulo33);
            AltaArticulo(articulo34);
            AltaArticulo(articulo35);
            AltaArticulo(articulo36);
            AltaArticulo(articulo37);
            AltaArticulo(articulo38);
            AltaArticulo(articulo39);
            AltaArticulo(articulo40);
            AltaArticulo(articulo41);
            AltaArticulo(articulo42);
            AltaArticulo(articulo43);
            AltaArticulo(articulo44);
            AltaArticulo(articulo45);
            AltaArticulo(articulo46);
            AltaArticulo(articulo47);
            AltaArticulo(articulo48);
            AltaArticulo(articulo49);
            AltaArticulo(articulo50);

            //Publicaciones /////////////////////

            // PRECARGA SUBASTAS
            List<Articulo> ListaSubasta1 = new List<Articulo>(); // Ropa sin uso
            ListaSubasta1.Add(articulo9);  // Camiseta
            ListaSubasta1.Add(articulo10); // Pantalones
            ListaSubasta1.Add(articulo11); // Chaqueta

            List<Articulo> ListaSubasta2 = new List<Articulo>(); // Peluches para niños
            ListaSubasta2.Add(articulo24); // Construcciones LEGO
            ListaSubasta2.Add(articulo25); // Puzzles

            List<Articulo> ListaSubasta3 = new List<Articulo>(); // Kit de escritorio
            ListaSubasta3.Add(articulo36); // Tijeras de oficina
            ListaSubasta3.Add(articulo37); // Silla de escritorio

            List<Articulo> ListaSubasta4 = new List<Articulo>(); // Artículos de tecnología
            ListaSubasta4.Add(articulo44); // Reproductor de música
            ListaSubasta4.Add(articulo45); // Smartwatch

            List<Articulo> ListaSubasta5 = new List<Articulo>(); // Cosas para el hogar
            ListaSubasta5.Add(articulo19); // Cojín
            ListaSubasta5.Add(articulo20); // Cortina

            List<Articulo> ListaSubasta6 = new List<Articulo>(); // Comidas
            ListaSubasta6.Add(articulo14); // Arroz
            ListaSubasta6.Add(articulo15); // Frijoles

            List<Articulo> ListaSubasta7 = new List<Articulo>(); // Televisor usado
            ListaSubasta7.Add(articulo5);  // Televisor

            List<Articulo> ListaSubasta8 = new List<Articulo>(); // Cargador de teléfono sin uso
            ListaSubasta8.Add(articulo8);   // Cargador portátil

            List<Articulo> ListaSubasta9 = new List<Articulo>(); // Conjunto vuelta a clases
            ListaSubasta9.Add(articulo10);  // Pantalones
            ListaSubasta9.Add(articulo39);  // Sudadera

            List<Articulo> ListaSubasta10 = new List<Articulo>(); // Cámara de seguridad
            ListaSubasta10.Add(articulo47); // Cámara de seguridad

            // Listas de Artículos para Ventas
            List<Articulo> ListaVenta1 = new List<Articulo>(); // Artículos Hogar
            ListaVenta1.Add(articulo19); // Cojín
            ListaVenta1.Add(articulo20); // Cortina
            ListaVenta1.Add(articulo21); // Mantel
            ListaVenta1.Add(articulo22); // Candelabro
            ListaVenta1.Add(articulo23); // Espejo decorativo

            List<Articulo> ListaVenta2 = new List<Articulo>(); // Electrónicos
            ListaVenta2.Add(articulo4);  // Smartphone
            ListaVenta2.Add(articulo5);  // Televisor
            ListaVenta2.Add(articulo6);  // Tablet
            ListaVenta2.Add(articulo7);  // Altavoz Bluetooth
            ListaVenta2.Add(articulo8);  // Cargador portátil

            List<Articulo> ListaVenta3 = new List<Articulo>(); // Ropa de Invierno
            ListaVenta3.Add(articulo11); // Chaqueta
            ListaVenta3.Add(articulo12); // Zapatos
            ListaVenta3.Add(articulo13); // Sombrero
            ListaVenta3.Add(articulo39); // Sudadera
            ListaVenta3.Add(articulo40); // Medias

            List<Articulo> ListaVenta4 = new List<Articulo>(); // Juguetes para Niños
            ListaVenta4.Add(articulo24); // Construcciones LEGO
            ListaVenta4.Add(articulo25); // Puzzles
            ListaVenta4.Add(articulo26); // Triciclo
            ListaVenta4.Add(articulo27); // Juego de cartas
            ListaVenta4.Add(articulo28); // Dinosaurio de juguete

            List<Articulo> ListaVenta5 = new List<Articulo>(); // Alimentos Saludables
            ListaVenta5.Add(articulo14); // Arroz
            ListaVenta5.Add(articulo15); // Frijoles
            ListaVenta5.Add(articulo16); // Azúcar
            ListaVenta5.Add(articulo17); // Aceite
            ListaVenta5.Add(articulo18); // Leche

            List<Articulo> ListaVenta6 = new List<Articulo>(); // Artículos de Oficina
            ListaVenta6.Add(articulo29); // Agenda
            ListaVenta6.Add(articulo30); // Batería
            ListaVenta6.Add(articulo31); // Herramienta multifuncional
            ListaVenta6.Add(articulo32); // Mochila
            ListaVenta6.Add(articulo36); // Tijeras de oficina

            List<Articulo> ListaVenta7 = new List<Articulo>(); // Decoración del Hogar
            ListaVenta7.Add(articulo19); // Cojín
            ListaVenta7.Add(articulo20); // Cortina
            ListaVenta7.Add(articulo21); // Mantel

            List<Articulo> ListaVenta8 = new List<Articulo>(); // Accesorios de Moda
            ListaVenta8.Add(articulo12); // Zapatos
            ListaVenta8.Add(articulo13); // Sombrero
            ListaVenta8.Add(articulo39); // Sudadera

            List<Articulo> ListaVenta9 = new List<Articulo>(); // Equipamiento Deportivo
            ListaVenta9.Add(articulo20); // Candelabro
            ListaVenta9.Add(articulo24); // Construcciones LEGO

            List<Articulo> ListaVenta10 = new List<Articulo>(); // Productos de Cuidado Personal
            ListaVenta10.Add(articulo30); // Batería
            ListaVenta10.Add(articulo31); // Herramienta multifuncional



            ///////////////////////////////////////////////////////////
            ///
            //VENTAS PRECARGADAS
            Publicacion v1 = new Venta("Articulos Hogar", ListaVenta1, true);
            Publicacion v2 = new Venta("Electrónicos", ListaVenta2, false);
            Publicacion v3 = new Venta("Ropa de Invierno", ListaVenta3, true);
            Publicacion v4 = new Venta("Juguetes para Niños", ListaVenta4, false);
            Publicacion v5 = new Venta("Alimentos Saludables", ListaVenta5, true);
            Publicacion v6 = new Venta("Artículos de Oficina", ListaVenta6, true);
            Publicacion v7 = new Venta("Decoración del Hogar", ListaVenta7, false);
            Publicacion v8 = new Venta("Accesorios de Moda", ListaVenta8, true);
            Publicacion v9 = new Venta("Equipamiento Deportivo", ListaVenta9, false);
            Publicacion v10 = new Venta("Productos de Cuidado Personal", ListaVenta10, true);

            //Precarga Subastas

            Publicacion s1 = new Subasta("Ropa sin uso", ListaSubasta1);
            //s1.FechaPublicacion = FechaAleatoria();
            Publicacion s2 = new Subasta("Peluches para niños", ListaSubasta2);
            Publicacion s3 = new Subasta("Kit de escritorio", ListaSubasta3);
            Publicacion s4 = new Subasta("Artículos de tecnología", ListaSubasta4);
            Publicacion s5 = new Subasta("Cosas para el hogar", ListaSubasta5);
            Publicacion s6 = new Subasta("Comidas", ListaSubasta6);
            Publicacion s7 = new Subasta("Televisor usado", ListaSubasta7);
            Publicacion s8 = new Subasta("Cargador de teléfono sin uso", ListaSubasta8);
            Publicacion s9 = new Subasta("Conjunto vuelta a clases", ListaSubasta9);
            Publicacion s10 = new Subasta("Cámara de seguridad", ListaSubasta10);


            s10.Estado = EstadoActual.CERRADA;

            AltaPublicacion(v1);
            AltaPublicacion(v2);
            AltaPublicacion(v3);
            AltaPublicacion(v4);
            AltaPublicacion(v5);
            AltaPublicacion(v6);
            AltaPublicacion(v7);
            AltaPublicacion(v8);
            AltaPublicacion(v9);
            AltaPublicacion(v10);

            AltaPublicacion(s1);
            AltaPublicacion(s2);
            AltaPublicacion(s3);
            AltaPublicacion(s4);
            AltaPublicacion(s5);
            AltaPublicacion(s6);
            AltaPublicacion(s7);
            AltaPublicacion(s8);
            AltaPublicacion(s9);
            AltaPublicacion(s10);

            //Realiza ofertas a subastas
            RealizarOferta(c1, 123, s1);
            RealizarOferta(c2, 258, s8);

            //Cambiar fechas a aleatorias y ordenarlas de manera ascendente
            OrdenYCambioDeFechas();
            //
        }

        public void OrdenYCambioDeFechas()
        {
            foreach (Publicacion s in _publicaciones)
            {
                if (s.GetType().Name == "Subasta")
                {
                    s.FechaPublicacion = FechaAleatoria();
                }
            }
            _publicaciones.Sort();
        }


        public void RealizarOferta(Usuario Usuario, double monto, Publicacion Subasta)
        {
            if (monto < 0)
            {
                throw new Exception("El monto no puede ser negativo");
            }
            if (Usuario is Cliente Cliente) //Verifica que el usuario sea cliente
            {
                if (monto <= Cliente.SaldoDisponible) //Comprueba que el usuario cuente con el saldo a ofertar
                {
                    Oferta f1 = new Oferta(Cliente, monto); //Realiza oferta
                    if (Subasta is Subasta s)
                    {
                        s.AgregarOferta(f1); //Agrega la oferta
                    }
                }
                else //En caso de no tener dinero 
                {
                    throw new Exception("No cuentas con ese dinero.");
                }
            }
        }
        public void AltaUsuario(Usuario u)
        {
            u.Validar();
            if (_usuarios.Contains(u)) //Se fija que el usuario no este ya registrado 
            {
                throw new Exception("Ya existe un usuario con ese mail");
            }
            _usuarios.Add(u);
        }

        public void AltaArticulo(Articulo a)
        {
            a.Validar();
            _articulos.Add(a);
        }
        public void AltaPublicacion(Publicacion p)
        {
            p.Validar();
            _publicaciones.Add(p);
        }

        //Devuelve una lista con Articulos de una categoria especifica 
        public List<Articulo> ObtenerArticulosCat(CategoriaArticulo cat)
        {
            List<Articulo> values = new List<Articulo>();

            foreach (Articulo A in _articulos)
            {
                if (A.Categoria == cat)
                {
                    values.Add(A);
                }
            }
            return values;
        }


        //Publicaciones entre dos fechas

        public List<Publicacion> GetPublicacionesDosFechas(DateTime f1, DateTime f2)
        {
            // Switch de fechas en caso de que f1 sea mayor a f2
            if (f1 > f2)
            {
                DateTime temp = f1;
                f1 = f2;
                f2 = temp;
            }

            List<Publicacion> ListaReturn = new List<Publicacion>(); // Lista a retornar

            foreach (Publicacion p in _publicaciones)
            {
                if (p.FechaPublicacion >= f1 && p.FechaPublicacion <= f2)
                {
                    ListaReturn.Add(p);
                }
            }

            return ListaReturn;
        }

        public Usuario Login(string email, string contrasenia) //Se fija que el usuario se encuentre registrado con ese mail y contraseña
        {
            foreach (Usuario p in _usuarios) 
            {
                if (p.Email.Equals(email) && p.Contrasenia.Equals(contrasenia)) 
                {
                    return p;
                }
            }

            throw new Exception("Datos de login no válidos");
        }

        public void DatosCorrectos(string nombre, string apellido, string email, string contrasenia)
        {

            // Verificar que ninguno de los datos sea null o vacío
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(contrasenia) || contrasenia.Length < 8)
            {
                throw new Exception("Datos incorrectos");
            }

            bool cont = false;
            bool contL = false;


            foreach (char c in contrasenia)
            {
                if (char.IsDigit(c))
                {
                    cont = true;

                }
                else if (char.IsLetter(c))
                {
                    contL = true;

                }
            }
            if (!email.Contains("@")) //Comprueba formato de mail
            {
                throw new Exception("Formato de correo no válido");

            }

            if (!cont || !contL)
            {
                throw new Exception("La contraseña debe ser alfanumérica");

            }
        }


        public Usuario GetUsuarioByID(int? id) //Obtiene un usuario dado un ID
        {
            foreach (var u in _usuarios)
            {
                if (u.Id == id)
                {
                    return u;
                }
            }
            throw new Exception("Usuario no encontrado");
        }


        public Publicacion GetPubByID(int id) //Obtiene una publicacion dado un ID
        {
            foreach (var c in _publicaciones)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            throw new Exception("Publicacion no encontrada");
        }

        private DateTime FechaAleatoria() //Retorna una fecha aleatoria entre 2023 y 2024
        {
            Random random = new Random();
            int anio = random.Next(2023, 2025);
            int mes = random.Next(1, 13);
            int dia = random.Next(1, 29);
            return new DateTime(anio, mes, dia);
        }
    }

}
