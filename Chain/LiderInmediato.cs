using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibilityPrestamo.Chain
{
    public class LiderInmediato : Aprobador
    {
        public override void AprobarPrestamo(Prestamo prestamo)
        {
            if(prestamo.Monto > 100000 && prestamo.Monto <= 500000)
            {
                prestamo.aprobado = true;
                Console.WriteLine("Prestamo de $" + prestamo.Monto + ", para el cliente " + prestamo.client.Nombre + ", aprobado por el Lider Inmediato.");
            }
            else
            {
                siguiente.AprobarPrestamo(prestamo);
            }
        }
    }
}
