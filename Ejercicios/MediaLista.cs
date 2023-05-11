using static System.Console;

class Lista
{
    public void mediaLista()
    {
        List<int> numeros = new List<int>();
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
        double media = numeros.Average();
        WriteLine("La media es: " + media);
    }
}
