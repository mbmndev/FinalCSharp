using static System.Console;
class Anagram
{
    public void anagrama()
    {
        string? palabra1 = "0";
        string? palabra2 = "0";
        while (palabra1.Length>0) {
        WriteLine("Introduzca la primera palabra a comparar: ");
        palabra1 = ReadLine();
        if (palabra1 == null) {
                WriteLine("Número inválido");
                palabra1 = "0";
                continue;
            }
        else {
            break;
        }
        }
        while (palabra2.Length>0) {
        WriteLine("Introduzca la segunda palabra a comparar: ");
        palabra2 = ReadLine();
        if (palabra2 == null) {
                WriteLine("Número inválido");
                palabra2 = "0";
                continue;
            }
        else {
            break;
        }
        }

        char[] letras1 = palabra1.ToLower().ToCharArray();
        char[] letras2 = palabra2.ToLower().ToCharArray();

        Array.Sort(letras1);
        Array.Sort(letras2);

        bool sonAnagramas = letras1.SequenceEqual(letras2);

        if (sonAnagramas)
        {
            WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
        }
        else
        {
            WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
        }
    }
}