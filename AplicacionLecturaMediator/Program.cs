using AplicacionLecturaMediator;
using System;

public class Program
{
    public static void Main()
    {
        var lector = new LectorNode("El principito", 96);
        var progreso = new ProgresoNode();
        var marcadores = new MarcadoresNode();
        var notas = new NotasNode();

        var mediador = new LectorMediator(
            lector,
            progreso,
            marcadores,
            notas);

        lector.CambiarPagina(10);
        marcadores.CrearMarcador(10, "Una frase importante");
        notas.CrearNota(10, "Revisar esta parte después.");

        lector.CambiarPagina(25);

        marcadores.MostrarMarcadores();
        notas.MostrarNotas();
    }
}