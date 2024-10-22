using System;

class Program
{
  public static void Main (string[] args) {
    //Exemplo 1-----------------------------------------------------------------
    Console.WriteLine ("Digite alguma coisa no teclado: ");

    
    //Capiturando a entrada do usuário------------------------------------------
    string entrada = Console.ReadLine();

  //exibindo o que o usuario digitou--------------------------------------------
    Console.WriteLine("Você digitou: " + entrada);

   //Exemplo 2-----------------------------------------------------------------
    
    Console.WriteLine("************************EX2************************: ");
    //Capiturando o primeiro valor ---------------------------------------------
    Console.WriteLine("Digite o primerio valor: ");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);

    //Capiturando o segundo valor -----------------------------------------------
    Console.WriteLine("Digite o segundo valor: ");
    string valor2 = Console.ReadLine();
    int numero2 = int.Parse(valor2);

    //Calculando a soma ---------------------------------------------------------
    int soma = numero1 + numero2;

    //Exibindo o resultado ------------------------------------------------------
    Console.WriteLine("A soma dos dois numero é: " + soma);
  }
}