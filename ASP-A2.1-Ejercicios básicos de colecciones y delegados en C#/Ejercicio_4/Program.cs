public class Ejercicio_4
{
    static void Main(string[] args)
    {
        var paises = new Dictionary<string, string>();

        paises.Add("España", "Madrid");
        paises.Add("Argentina", "Buenos Aires");
        paises.Add("Colombia", "Bogota");

        foreach (var item in paises)
        {
            Console.WriteLine(item);
        }
    }
}
