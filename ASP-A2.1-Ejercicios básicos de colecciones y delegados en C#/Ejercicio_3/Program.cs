public class Ejercicio_3
{
    static void Main(string[] args)
    {
        var pila = new Stack<string>();

        pila.Push("A");
        pila.Push("B");
        pila.Push("C");

        // para mostrar el elemnto que esta mas arriba
        Console.WriteLine($"Elemento superior: {pila.Peek()}");

        // este bucle for es para que vaya quitando los elemntos
        for(int i = 0; i < 3; i++) { 
        // para mostrarlos, siempre sera el de mas arriba y se iran eliminando
        Console.WriteLine($"Desapilando:{pila.Pop()}");
        }

        // muestra los que quedan
        Console.WriteLine($"Total restante: {pila.Count}");
        Console.WriteLine("Elementos restantes:");

        // para recorrer la pila
        foreach (var e in pila)
            Console.WriteLine(e);
    }
}