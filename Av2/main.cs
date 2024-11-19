using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Semafaro preste atenção");
     String siga = "amarelo";

        if(siga == "verde"){
            Console.Write("Pode passar");
        }else if(siga == "amarelo"){
            Console.Write("Atenção");
        }if(siga == "vermelho"){
            Console.Write("Pare");
        }
        
      

    }
}