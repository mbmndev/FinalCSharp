using static System.Console;
class Bisiesto
{
    public void anyoBisiesto()
    {
        while (true)
        {
            WriteLine("Introduce el año para saber si es bisiesto. Escriba 'FIN' para terminar el programa.");
            string? anyo = ReadLine();
            if (anyo == "FIN")
            {
                break;
            }
            int anyoEntero = Convert.ToInt32(anyo);
            if ((anyoEntero % 4 == 0) && (anyoEntero % 100 != 0))
            {
                WriteLine($"El año {anyo} es bisiesto");
            }
            else if (anyoEntero % 400 == 0)
            {
                WriteLine($"El año {anyo} no es bisiesto");
            }
            else
            {
                WriteLine($"El año {anyo} no es bisiesto");
            }
        }
    }
}