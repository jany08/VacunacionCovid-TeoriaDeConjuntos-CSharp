using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Crear conjunto de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 2. Crear conjunto de 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 3. Crear conjunto de 75 vacunados con AstraZeneca
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // 4. Operaciones de teoría de conjuntos

        // Ambas dosis (Intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Solo AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // No vacunados
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // Mostrar resultados
        Console.WriteLine("TOTAL CIUDADANOS: " + ciudadanos.Count);
        Console.WriteLine("PFIZER: " + pfizer.Count);
        Console.WriteLine("ASTRAZENECA: " + astraZeneca.Count);
        Console.WriteLine("AMBAS DOSIS: " + ambasDosis.Count);
        Console.WriteLine("SOLO PFIZER: " + soloPfizer.Count);
        Console.WriteLine("SOLO ASTRAZENECA: " + soloAstra.Count);
        Console.WriteLine("NO VACUNADOS: " + noVacunados.Count);

        Console.ReadLine();
    }
}