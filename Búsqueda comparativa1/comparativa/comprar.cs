using System;
using System.Collections.Generic;
using System.Diagnostics;

class comprar
{
    public void Ejecutar()
    {
        const int N = 100000;
        Stopwatch sw = new Stopwatch();

        // Arreglo
        int[] array = new int[N];
        sw.Start();
        for (int i = 0; i < N; i++) array[i] = i;
        sw.Stop();
        Console.WriteLine($"Array: Inserción = {sw.ElapsedMilliseconds} ms");
        sw.Reset();

        // List
        List<int> lista = new List<int>();
        sw.Start();
        for (int i = 0; i < N; i++) lista.Add(i);
        sw.Stop();
        Console.WriteLine($"List: Inserción = {sw.ElapsedMilliseconds} ms");
        sw.Reset();

        // LinkedList
        LinkedList<int> enlazada = new LinkedList<int>();
        sw.Start();
        for (int i = 0; i < N; i++) enlazada.AddLast(i);
        sw.Stop();
        Console.WriteLine($"LinkedList: Inserción = {sw.ElapsedMilliseconds} ms");
        sw.Reset();

        // SortedList
        SortedList<int, string> ordenada = new SortedList<int, string>();
        sw.Start();
        for (int i = 0; i < N / 10; i++) ordenada.Add(i, i.ToString());
        sw.Stop();
        Console.WriteLine($"SortedList: Inserción = {sw.ElapsedMilliseconds} ms");
        sw.Reset();

        // Dictionary
        Dictionary<int, string> diccionario = new Dictionary<int, string>();
        sw.Start();
        for (int i = 0; i < N; i++) diccionario.Add(i, i.ToString());
        sw.Stop();
        Console.WriteLine($"Dictionary: Inserción = {sw.ElapsedMilliseconds} ms\n");

        //Busquedas 

        int primer = 0;
        int ultimo = N - 1;
        int inexistente = N + 1;

        // Array
        sw.Restart();
        Array.Exists(array, x => x == primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento del array:  {sw.ElapsedTicks}");

        sw.Restart();
        Array.Exists(array, x => x == ultimo);
        sw.Stop();
        Console.WriteLine($"Ultimo elemento del array:  {sw.ElapsedTicks}");

        sw.Restart();
        Array.Exists(array, x => x == inexistente);
        sw.Stop();
        Console.WriteLine($"Elemento no existente para el array: {sw.ElapsedTicks}");

        // List
        sw.Restart();
        lista.Contains(primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento en list: {sw.ElapsedTicks}  ticks");

        sw.Restart();
        lista.Contains(ultimo);
        sw.Stop();
        Console.WriteLine($"Ultimo elemento en list: {sw.ElapsedTicks} ticks");

        sw.Restart();
        lista.Contains(inexistente);
        sw.Stop();
        Console.WriteLine($"Elemento no existente en list: {sw.ElapsedTicks}  ticks");

        // LinkedList
        sw.Restart();
        enlazada.Contains(primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento en LinkedList: {sw.ElapsedTicks}  ticks");

        sw.Restart();
        enlazada.Contains(ultimo);
        sw.Stop();
        Console.WriteLine($"Ultimo elemento en LinkedList: = {sw.ElapsedTicks}  ticks");

        sw.Restart();
        enlazada.Contains(inexistente);
        sw.Stop();
        Console.WriteLine($"Elemento no existente en LinkedList: {sw.ElapsedTicks}  ticks");

        // SortedList
        sw.Restart();
        ordenada.ContainsKey(0);
        sw.Stop();
        Console.WriteLine($"Primer elemento en SortedList: {sw.ElapsedTicks}  ticks");

        sw.Restart();
        ordenada.ContainsKey(N / 10 - 1);
        sw.Stop();
        Console.WriteLine($"Ultimo elemento en SortedList: {sw.ElapsedTicks}  ticks");

        sw.Restart();
        ordenada.ContainsKey(inexistente);
        sw.Stop();
        Console.WriteLine($"Elemento no existe en SortedList: {sw.ElapsedTicks} ticks");

        // Dictionary
        sw.Restart();
        diccionario.ContainsKey(primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento en Dictionary: {sw.ElapsedTicks} ticks");

        sw.Restart();
        diccionario.ContainsKey(ultimo);
        sw.Stop();
        Console.WriteLine($"Ultimo elemento en Dictionary: {sw.ElapsedTicks} ticks");

        sw.Restart();
        diccionario.ContainsKey(inexistente);
        sw.Stop();
        Console.WriteLine($"Elemento inexistente en Diccionario: {sw.ElapsedTicks} ticks");



        // Eliminar


        // List
        sw.Restart();
        lista.Remove(primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento eliminado en List: {sw.ElapsedTicks} ticks");

        // LinkedList
        sw.Restart();
        enlazada.Remove(primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento eliminado en LinkedList: {sw.ElapsedTicks} ticks");

        //SortedList
        sw.Restart();
        ordenada.Remove(0);
        sw.Stop();
        Console.WriteLine($"Primer elemento eliminado en SortedList: {sw.ElapsedTicks} ticks");

        // Dictionary
        sw.Restart();
        diccionario.Remove(primer);
        sw.Stop();
        Console.WriteLine($"Primer elemento eliminado en Dictionary: {sw.ElapsedTicks} ticks");
    }
}
