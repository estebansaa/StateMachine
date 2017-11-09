using AfterStatePattern.Domian;

namespace AfterStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo(20);

            v.Acelerar();
            v.Contacto();
            v.Acelerar();
            v.Acelerar();
            v.Acelerar();
            v.Frenar();
            v.Frenar();
            v.Frenar();
            v.Frenar();

        }
    }
}
