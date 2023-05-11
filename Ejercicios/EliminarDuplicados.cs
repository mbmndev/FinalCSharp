using static System.Console;

class Duplicados
{
    public void eliminarDuplicados()
    {
        List<int> numeros = new List<int>();
        List<int> numerosSinDuplicados = new List<int>();
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

        foreach (int numer in numeros)
        {
            if (!numerosSinDuplicados.Contains(numer))
            {
                numerosSinDuplicados.Add(numer);
            }
        }

        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Números sin duplicar: " + string.Join(", ", numerosSinDuplicados));

    }
}