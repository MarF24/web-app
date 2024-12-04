using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Dominio
{
    public class Usuario
    {
        private static int _ultimoId = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        public Usuario(string nombre, string apellido, string email, string contrasenia)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasenia = contrasenia;
        }
        public Usuario()
        {
            Id = _ultimoId++;
        }

        public void Validar() //Verifica que los campos no esten vacios

        {

            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre no puede ser vacio");
            }

            if (String.IsNullOrEmpty(Apellido))
            {
                throw new Exception("El apellido no puede ser vacio");
            }

            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("El email no puede ser vacio");
            }

            if (String.IsNullOrEmpty(Contrasenia))
            {
                throw new Exception("La contraseña no puede ser vacio");
            }
        }

        public override bool Equals(object obj)
        {
            if ((obj is Usuario u) && Email == u.Email)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

