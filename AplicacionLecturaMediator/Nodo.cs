using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public abstract class Nodo
    {
        protected ILectorMediator Mediador;

        public void AsignarMediador(ILectorMediator mediador)
        {
            Mediador = mediador;
        }
    }
}
