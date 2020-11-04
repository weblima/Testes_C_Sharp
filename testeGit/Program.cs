using Microsoft.VisualBasic.CompilerServices;
using System;

namespace testeGit {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bom dia, Qual seu nome?");
            string entrada = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Oi " + entrada + " Seja bem vindo!");

            for (int i=0; i < 10; i++) {

                Console.WriteLine("Valor i == " + i);

            }

            Console.WriteLine("");
        }
    }
}
