using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public class LectorMediator : ILectorMediator
    {
        private readonly LectorNode lector;
        private readonly ProgresoNode progreso;
        private readonly MarcadoresNode marcadores;
        private readonly NotasNode notas;

        public LectorMediator(
            LectorNode lector,
            ProgresoNode progreso,
            MarcadoresNode marcadores,
            NotasNode notas)
        {
            this.lector = lector;
            this.progreso = progreso;
            this.marcadores = marcadores;
            this.notas = notas;

            lector.AsignarMediador(this);
            progreso.AsignarMediador(this);
            marcadores.AsignarMediador(this);
            notas.AsignarMediador(this);
        }

        public void PaginaCambiada(int pagina)
        {
            Console.WriteLine($"\nLibro: {lector.TituloLibro}");
            progreso.Actualizar(pagina, lector.TotalPaginas);
        }

        public void GuardarMarcador(int pagina, string etiqueta)
        {
            if (!PaginaValida(pagina) || string.IsNullOrWhiteSpace(etiqueta))
            {
                Console.WriteLine("No se pudo guardar el marcador.");
                return;
            }

            marcadores.AgregarMarcador(pagina, etiqueta);
        }

        public void GuardarNota(int pagina, string texto)
        {
            if (!PaginaValida(pagina) || string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("No se pudo guardar la nota.");
                return;
            }

            notas.AgregarNota(pagina, texto);
        }

        private bool PaginaValida(int pagina)
        {
            return pagina >= 1 && pagina <= lector.TotalPaginas;
        }
    }
}
