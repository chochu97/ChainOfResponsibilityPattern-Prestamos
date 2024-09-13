using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibilityPrestamo
{
    public class Prestamo
    {
        public double Monto { get; set; }
        public Cliente client { get; set; }
        public bool aprobado { get; set; }

        public Prestamo(double monto, Cliente cli)
        {
            Monto = monto;
            client = cli;
        }
    }
}
