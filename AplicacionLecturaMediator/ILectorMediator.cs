using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public interface ILectorMediator
    {
        void PaginaCambiada(int pagina);
        void GuardarMarcador(int pagina, string etiqueta);
        void GuardarNota(int pagina, string texto);
    }
}
