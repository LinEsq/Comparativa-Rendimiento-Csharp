using Busqueda_comparativa1.Listas_cmplejidad;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> sueldos = new List<double>()
        {
            500000,450000,600000,520000,480000
        };

        aguinaldos a = new aguinaldos(sueldos);

        double totalRec = a.Recursivo(0);
        double tiempoRec = a.TiempoRecursivo();

        double totalIte = a.Iterativo();
        double tiempoIte = a.TiempoIterativo();

        Console.WriteLine($"Recursivo -> Tiempo: {tiempoRec} ms | Aguinaldo total: {totalRec}");
        Console.WriteLine($"Iterativo -> Tiempo: {tiempoIte} ms | Aguinaldo total: {totalIte}");
    }
}
