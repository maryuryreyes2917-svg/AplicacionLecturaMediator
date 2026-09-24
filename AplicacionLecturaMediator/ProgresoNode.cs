using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public class ProgresoNode : Nodo
    {
        public void Actualizar(int pagina, int totalPaginas)
        {
            double porcentaje = (double)pagina / totalPaginas * 100;

            Console.WriteLine(
                $"Progreso: página {pagina} de {totalPaginas} " +
                $"({porcentaje:F1} %).");
        }
    }
}
