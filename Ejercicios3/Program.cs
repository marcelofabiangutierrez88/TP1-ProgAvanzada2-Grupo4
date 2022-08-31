using System.Drawing;

public class Program
{
    public static void Main()
    {
        DimeColor("blanco");
        

        }
    public static string DimeColor(string color)
    {
        string rta = "";
        switch (color)
        {
            case "blanco":
                return rta = "El color es blanco";
                break;
            case "azul":
                return rta = "El color es azul";
                break;
            case "negro":
                return rta = "El color es negro";
                break;
        }
        return rta = "Vuelva a seleccionar";
    }

}