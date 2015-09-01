using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABNTApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite seu nome completo:");
            String nomeCompleto = Console.ReadLine();
            string[] nomeArr = nomeCompleto.Split(' ');
            string[] prepArr = { "DOS", "DAS", "DO", "DA", "E", "DEL", "DE" };
            String primeiroNome = nomeArr[0];
            String ultimoNome = nomeArr[nomeArr.Length-1];
            String meio = "";
            if(nomeArr.Length > 2)
            {
                for (int i =1; i < nomeArr.Length-1; i++)
                {   if(prepArr.Contains(nomeArr[i].ToUpper()))
                    {
                        meio += nomeArr[i] + " ";
                    }
                    else
                    {
                        meio += nomeArr[i].Substring(0, 1).ToUpper() + ". ";
                    }
                    
                }
            }
            Console.WriteLine(ultimoNome.ToUpper() + ", "+ primeiroNome+" "+ meio );
            Console.ReadKey();
        }
    }
}
