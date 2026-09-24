using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public class NotasNode : Nodo
    {
        private readonly List<string> notas = new List<string>();

        public void CrearNota(int pagina, string texto)
        {
            Mediador.GuardarNota(pagina, texto);
        }

        public void AgregarNota(int pagina, string texto)
        {
            notas.Add($"Página {pagina}: {texto}");
            Console.WriteLine("Nota guardada.");
        }

        public void MostrarNotas()
        {
            Console.WriteLine("\nNotas guardadas:");

            if (notas.Count == 0)
            {
                Console.WriteLine("Todavía no hay notas.");
                return;
            }

            foreach (string nota in notas)
            {
                Console.WriteLine("- " + nota);
            }
        }
    }
}
