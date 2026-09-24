using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionLecturaMediator
{
    public class MarcadoresNode : Nodo
    {
        private readonly List<string> marcadores = new List<string>();

        public void CrearMarcador(int pagina, string etiqueta)
        {
            Mediador.GuardarMarcador(pagina, etiqueta);
        }

        public void AgregarMarcador(int pagina, string etiqueta)
        {
            marcadores.Add($"Página {pagina}: {etiqueta}");
            Console.WriteLine("Marcador guardado.");
        }

        public void MostrarMarcadores()
        {
            Console.WriteLine("\nMarcadores guardados:");

            if (marcadores.Count == 0)
            {
                Console.WriteLine("Todavía no hay marcadores.");
                return;
            }

            foreach (string marcador in marcadores)
            {
                Console.WriteLine("- " + marcador);
            }
        }
    }
} 