using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public class LectorNode : Nodo
    {
        public string TituloLibro { get; }
        public int TotalPaginas { get; }
        public int PaginaActual { get; private set; }

        public LectorNode(string tituloLibro, int totalPaginas)
        {
            TituloLibro = tituloLibro;
            TotalPaginas = totalPaginas;
            PaginaActual = 1;
        }

        public void CambiarPagina(int pagina)
        {
            if (pagina < 1 || pagina > TotalPaginas)
            {
                Console.WriteLine("Esa página no existe en este libro.");
                return;
            }

            PaginaActual = pagina;
            Mediador.PaginaCambiada(pagina);
        }
    }
}
