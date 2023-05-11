using static System.Console;

class MenorMayor
{
    public void menorMayor()
    {
        List<int> numerosEnteros = new List<int>();
        int numeroMayor = 0;
        int numeroMenor = 0;
        int i = 0;
        while (true)
        {
            WriteLine("Introduzca un nuevo número entero. Escriba FIN para terminar la lista.");
            string? numero = (ReadLine());
            if (numero == "FIN")
            {
                break;
            }
            int numeroEntero = Convert.ToInt32(numero);
            numerosEnteros.Add(numeroEntero);
            if (i == 0)
            {
                numeroMayor = numeroEntero;
                numeroMenor = numeroEntero;
            }
            else
            {
                if (numeroEntero > numeroMayor)
                {
                    numeroMayor = numeroEntero;
                }
                if (numeroEntero < numeroMenor)
                {
                    numeroMenor = numeroEntero;
                }
            }
            i++;
        }
        WriteLine($"El mayor número de la lista es {numeroMayor}");
        WriteLine($"El menor número de la lista es {numeroMenor}");
    }
}