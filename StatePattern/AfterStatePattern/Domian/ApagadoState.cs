using System;


namespace AfterStatePattern.Domian
{
    public class ApagadoState : IState
    {
        // Referencia a la clase de contexto
        private Vehiculo _vehiculo;
        public ApagadoState(Vehiculo v)
        {
            _vehiculo = v;
        }
        public void Acelerar()
        {
            // Acelerar con el vehiculo apagado no sirve de mucho<img width="16" height="16" class="wp-smiley emoji" draggable="false" alt=":)" src="https://s1.wp.com/wp-content/mu-plugins/wpcom-smileys/simple-smile.svg" style="height: 1em; max-height: 1em;" scale="0">
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }

        public void Frenar()
        {
            // Frenar con el vehiculo parado tampoco sirve de mucho...
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }

        public void Contacto()
        {
            // Comprobamos que el vehiculo disponga de combustible
            if (_vehiculo.CombustibleActual > 0)
            {
                // El vehiculo arranca -> Cambio de estado
                //estado = PARADO;
                _vehiculo.Estado = new ParadoState(_vehiculo);
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                _vehiculo.VelocidadActual = 0;
            }
            else
            {
                // El vehiculo no arranca -> Sin combustible
                //estado = SIN COMBUSTIBLE
                _vehiculo.Estado = new SinCombustibleState(_vehiculo);
                Console.WriteLine("El vehiculo se encuentra sin combustible");
            }
        }
    }
}
