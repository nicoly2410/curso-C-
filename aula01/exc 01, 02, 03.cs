using System;

class Program
{
    public static void Main(string[] args)
    {
        //exercicio 1--------------------------------------------
        Console.WriteLine("Digite alguma coisa no teclado");


        //Capturando a entrada do usuário-----------------------
        string entrada = Console.ReadLine();

        //Exibinda o que o usuario digitou ---------------------
        Console.WriteLine("Você digitou: " + entrada);

        //exercicio 2--------------------------------------------
        Console.WriteLine("***************atividade 2**************");

        //Capturando o primeiro valor----------------------------
        Console.WriteLine("Digite o primeiro valor");
        string valor1 = Console.ReadLine();
        int numero1 = int.Parse(valor1);

        //Capturando o segundo valor-----------------------------
        Console.WriteLine("Digite o segundo valor");
        string valor2 = Console.ReadLine();
        int numero2 = int.Parse(valor2);

        //Capturando o terceiro valor-----------------------------
        Console.WriteLine("Digite o terceiro valor");
        string valor3 = Console.ReadLine();
        int numero3 = int.Parse(valor3);

        //exercicio 3 calculando média------------------------------------
        int media = (numero1 + numero2 + numero3) / 3;
        Console.WriteLine("A media é: " + media);
    }
}