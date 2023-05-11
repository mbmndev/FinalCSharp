using static System.Console;

class Pares
{

    public void sumaNumerosPares()
    {
        List<int> numeros = new List<int>();
        int suma = 0;
        string? numero = "0";
        int num;
        while(numero.Length>0){
            WriteLine("Introduzca un nuevo número a la lista. Enter para finalizar");
            numero = ReadLine();
            if (numero == null) {
                WriteLine("Número inválido");
                numero = "0";
                continue;
            }
            try {
                Int32.TryParse(numero, out num);
                if (numero.Length>0){
                numeros.Add(num);
                }
            }
            catch {
                if (numero != "") {
                WriteLine("Entrada inválida");
                continue;
                }
            }
        }
        
        foreach (int nume in numeros)
        {
            if (nume % 2 == 0)
                suma += nume;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        ReadKey();
    }
}