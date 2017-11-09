using StatePattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoBasico vb = new VehiculoBasico();
            vb.Acelerar();
            vb.Contacto();
            vb.Acelerar();
            vb.Acelerar();
            vb.Acelerar();
            vb.Frenar();
            vb.Frenar();
            vb.Frenar();
            vb.Frenar();

            Console.ReadKey();
        }
    }
}
