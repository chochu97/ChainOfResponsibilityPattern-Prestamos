using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibilityPrestamo.Chain
{
    public class Gerente : Aprobador
    {
        public override void AprobarPrestamo(Prestamo prestamo)
        {
            if(prestamo.Monto > 500000 && prestamo.Monto <= 1000000)
            {
                prestamo.aprobado = true;
                Console.WriteLine("Prestamo de $" + prestamo.Monto + ", para el cliente " + prestamo.client.Nombre + ", aprobado por el Gerente.");
            }
            else
            {
                siguiente.AprobarPrestamo(prestamo);
            }
        }
    }
}
