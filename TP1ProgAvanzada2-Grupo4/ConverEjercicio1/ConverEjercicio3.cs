public class ConverEjercicio3

{
    public static void Main()
    {
        String color = ValidateColor("blanco");
       
    }
    public static String ValidateColor(String color)
    {
        switch (color)
        {
            case "blanco":
                Console.WriteLine("El color es blanco");
                return ("El color es blanco");
            case "azul":
                Console.WriteLine("El color es azul");
                return ("El color es azul");
            case "negro":
                Console.WriteLine("El color es negro");
                return ("El color es negro");
        }
        return color;
    }
}