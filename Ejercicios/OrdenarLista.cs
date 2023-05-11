using static System.Console;

class Ordenar
{
    public void ordenarLista()
    {
        List<string> nombres = new List<string>();
        string? nombre = "0";
        while (nombre.Length > 0)
        {
            WriteLine("Introduzca un nuevo nombre a la lista. Enter para finalizar");
            nombre = ReadLine();
            if (nombre == null) {
                WriteLine("Número inválido");
                nombre = "0";
                continue;
            }
            if (nombre.Length > 0)
            {
                nombres.Add(nombre);
            }
        }
        nombres.Sort();
        WriteLine("Lista ordenada alfabéticamente:");
        foreach (string nom in nombres)
        {
            WriteLine(nom);
        }
    }
}    