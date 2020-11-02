using Microsoft.VisualBasic.CompilerServices;
using System;

namespace testeGit {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bom dia, Qual seu nome?");
            string entrada = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Oi " + entrada + " Seja bem vindo!");
        }
    }
}
