public class Ejercicio_2
{
    static void Main(string[] args)
    {
        var cola = new Queue<string>();
        cola.Enqueue("Iker");
        cola.Enqueue("Rafa");
        cola.Enqueue("Tovar");

        foreach (var item in cola)
        {
            Console.WriteLine(item);
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Atendiendo a: {cola.Dequeue()}");
        }
    }
}