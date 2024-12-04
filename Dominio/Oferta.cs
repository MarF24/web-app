using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Oferta
    {
        private static int _ultimoId = 0;
        public int Id { get; set; }
        public Cliente Usuario { get; set; }
        public double Monto { get; set; }
        public DateTime FechaOferta { get; set; }

        public Oferta(Cliente usuario, double monto)
        {
            Id = _ultimoId++;
            Usuario = usuario;
            Monto = monto;
            FechaOferta = DateTime.Now;
        }

        public void Validar()
        {
            if(Usuario.SaldoDisponible <= Monto)
            {
                throw new Exception("El saldo disponible debe ser mayor al monto");
            }    
            
        }
    }
}