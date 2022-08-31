public class Ejercicio7
{
    public static void Main()
    {
        int a = 10;
        Validation(a);
    }
    public static void Validation(int a)
    {
        while (a < 50)
        {
            a += 5;
            Console.WriteLine(a);
        }
    }
}