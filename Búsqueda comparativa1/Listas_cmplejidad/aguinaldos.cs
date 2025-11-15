using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_comparativa1.Listas_cmplejidad
{
    public class aguinaldos
    {
        public List<double> Sueldos;

        public aguinaldos(List<double> sueldos)
        {
            Sueldos = sueldos;
        }

        // metodo para recursion
        public double Recursivo(int index)
        {
            if (index == Sueldos.Count)
                return 0;

            return Sueldos[index] + Recursivo(index + 1);
        }

        // metodo para iterar
        public double Iterativo()
        {
            double total = 0;
            foreach (double s in Sueldos)
                total += s;
            return total;
        }

        // medir el tiempo recursivo
        public double TiempoRecursivo()
        {
            var sw = Stopwatch.StartNew();
            Recursivo(0);
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        // medir el tiempo iterativo
        public double TiempoIterativo()
        {
            var sw = Stopwatch.StartNew();
            Iterativo();
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
