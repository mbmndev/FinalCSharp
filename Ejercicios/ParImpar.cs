using static System.Console;

class ParImpar
{
    public void parImpar()
    {
        while (true)
        {
            WriteLine("Introduzca un nuevo número entero. Escriba FIN para terminar la lista.");
            string? numero = (ReadLine());
            if (numero == "FIN")
            {
                break;
            }
            int numeroEntero = Convert.ToInt32(numero);
            if (numeroEntero % 2 == 0)
            {
                WriteLine($"El número {numeroEntero} es par");
            }
            else
            {
                WriteLine($"El número {numeroEntero} es impar");
            }
        }
    }
}