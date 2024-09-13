using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibilityPrestamo.Chain
{
    public class Director : Aprobador
    {
        public override void AprobarPrestamo(Prestamo prestamo)
        {
                prestamo.aprobado = true;
                Console.WriteLine("Prestamo de $" + prestamo.Monto + ", para el cliente " + prestamo.client.Nombre + ", aprobado por el Director.");
        }
    }
}
