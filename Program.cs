using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string FraseDoUsuario;
            Console.WriteLine("Olá usuario, por favor, digite uma frase qualquer");
            FraseDoUsuario = Console.ReadLine();

            Console.WriteLine($"Você digitou {FraseDoUsuario.ToUpper()}");
        }
    }
}
