using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibilityPrestamo
{
    public abstract class Aprobador
    {
        protected Aprobador siguiente;

        public void AgregarSiguiente(Aprobador app)
        {
            siguiente = app;
        }

        public abstract void AprobarPrestamo(Prestamo prestamo);
    }
}
