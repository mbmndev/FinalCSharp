using static System.Console;

bool entero = true;
while (entero)
{
    WriteLine("Seleccione uno de los siguientes 15 ejercicios");

    WriteLine("1 - Adivinar número");
    WriteLine("2 - Anagrama");
    WriteLine("3 - Año bisiesto");
    WriteLine("4 - Área volumen cubo");
    WriteLine("5 - Capicúa");
    WriteLine("6 - Eliminar duplicados");
    WriteLine("7 - Factorial");
    WriteLine("8 - Media lista");
    WriteLine("9 - Menor mayor");
    WriteLine("10 - Número positivo negativo cero");
    WriteLine("11 - Numero primo");
    WriteLine("12 - Ordenar lista");
    WriteLine("13 - Palindromo");
    WriteLine("14 - Par impar");
    WriteLine("15 - Suma Numeros Pares");

    WriteLine("0 - Salir");

    WriteLine("Seleccione una opción:");
    string? opcion = ReadLine();
    entero = Int32.TryParse(opcion, out int opc);
    switch (opc)
    {
        case 1:
            Adivinanza mi_adivinarNumero = new Adivinanza();
            mi_adivinarNumero.adivinarNumero();
            break;
        case 2:
            Anagram mi_anagrama = new Anagram();
            mi_anagrama.anagrama();
            break;
        case 3:
            Bisiesto mi_anyoBisiesto = new Bisiesto();
            mi_anyoBisiesto.anyoBisiesto();
            break;
        case 4:
            Cubo mi_cubo = new Cubo();
            mi_cubo.areaVolumenCubo();
            break;
        case 5:
            Capicua mi_capicua = new Capicua();
            mi_capicua.capicua();
            break;
        case 6:
            Duplicados mi_duplicados = new Duplicados();
            mi_duplicados.eliminarDuplicados();
            break;
        case 7:
            Factorial mi_factorial = new Factorial();
            mi_factorial.factorial();
            break;
        case 8:
            Lista mi_lista = new Lista();
            mi_lista.mediaLista();
            break;
        case 9:
            MenorMayor mi_menor = new MenorMayor();
            mi_menor.menorMayor();
            break;
        case 10:
            Cero mi_cero = new Cero();
            mi_cero.numeroPositivoNegativoCero();
            break;
        case 11:
            Primo mi_primo = new Primo();
            mi_primo.numeroPrimo();
            break;
        case 12:
            Ordenar mi_ordenar = new Ordenar();
            mi_ordenar.ordenarLista();
            break;
        case 13:
            Palin mi_palin = new Palin();
            mi_palin.palindromo();
            break;
        case 14:
            ParImpar mi_parImpar = new ParImpar();
            mi_parImpar.parImpar();
            break;
        case 15:
            Pares mi_pares = new Pares();
            mi_pares.sumaNumerosPares();
            break;
        case 0:
            break;
    }
    WriteLine("Pulsa una tecla para continuar...");
    ReadKey();
    if (opc == 0)
    {
        break;
    }
}