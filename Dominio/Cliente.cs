using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Usuario
    {
        public double SaldoDisponible { get; set; }
        public Cliente(string nombre, string apellido, string email, string contrasenia, double saldoDisponible) : base(nombre, apellido, email, contrasenia)
        {
            SaldoDisponible = saldoDisponible;
        }

        public Cliente() : base() { }
     
        public double ObtenerSaldo()
        {
            return SaldoDisponible;
        }

        public void CargarSaldo(double monto)
        {
            if (monto < 0)
            {
                throw new Exception("El monto no puede ser negativo");
            }
            else
            {
                SaldoDisponible += monto;
            }
        }

        public override string ToString()
        {
            return $"{Nombre}, {Apellido}, {SaldoDisponible} - Usuario";
        }

        public void Validar()
        {
            if (SaldoDisponible <= 0)
            {
                throw new Exception("El saldo debe ser mayor a 0");
            }

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
    }
}
