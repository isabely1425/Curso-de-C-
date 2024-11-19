using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Calcule a área do retângulo");
    Console.WriteLine("Digite o valor da base:");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);

    //segundo valor
    Console.WriteLine("Digite o valor da altura:");
    string valor2 = Console.ReadLine();
    int numero2 = int.Parse(valor2);

    // calculando a multiplicação
    int multiplicacao = numero1 * numero2;

    // Exibindo o resultado
    Console.WriteLine("O valor da area é: " + multiplicacao);
  }
}