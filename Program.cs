using System;

namespace Inicio com C# 
{
  class Program 
  {
     static void Main(string[] args)
     {
       // Variáveis
       //Atribuir valor  elas
        int numero = 10;
        int valor_2 = 5;
        Console.WriteLine("Quanto é" + numero + " + " + numero_2 + "?");
       
        int resposta = Convert.ToInt32(Console.ReadLine());
        
        // Estrutura condicional
        
        if (resposta == 15)
        {
          Console.WriteLine("Parabéns! você acertou!");
        } else
        {
         Console.WriteLine("Tente novamente!");
        
     }
  }
  
}
