public class Ejercicio_1
{
    public static void Main(String[] args)
    {
        //una manera de hacerlo
        //var numeros = new List<int> { 1, 2, 3, 4, 5 };
        // otra manera de hacerlo
        var numeros = new List<int>();
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);
        numeros.Add(4);
        numeros.Add(5);

        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }
    }
}