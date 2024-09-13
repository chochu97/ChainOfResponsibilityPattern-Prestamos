using ChainResponsibilityPrestamo.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibilityPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Cliente("Flor Giova");

            var ejecut = new EjecutivoDeCuenta();
            var lider = new LiderInmediato();
            var gerent = new Gerente();
            var direc = new Director();

            ejecut.AgregarSiguiente(lider);
            lider.AgregarSiguiente(gerent);
            gerent.AgregarSiguiente(direc);

            double importe = 1;

            while(importe != 0)
            {
                Console.WriteLine("Ingrese el Monto del prestamo a solicitar (0 para cancelar)");
                importe = double.Parse(Console.ReadLine());
                var pres = new Prestamo(importe, client);
                ejecut.AprobarPrestamo(pres);

            }


        }
    }
}
