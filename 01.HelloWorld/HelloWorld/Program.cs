using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(String[] args)
        {
            //Tipos: Int, Float, Bool, Strting, Char, 
            //String é com "" e Char é com ''
            
            string texto = "teste";
            Console.WriteLine(texto);

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Meu nome é Richard");
            Console.ReadLine();
           

            Console.WriteLine("Escreva seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Seu nome é:");
            Console.WriteLine(nome);
            
        }
    }
}