using System;

namespace ArrayNaEmpresa
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] aluguels = new Aluguel[10];   //Criando um array com 10 posições vazias

            for (int i = 0; i < n; i++) {
                Console.Write("Name: ");
                String Name = Console.ReadLine();

                Console.Write("Email: ");
                String Email = Console.ReadLine();

                Console.Write("Room: ");
                int Room = int.Parse(Console.ReadLine());

                aluguels[Room-1] = new Aluguel(Name, Email, Room);

                Console.WriteLine("");
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++) {
                if (aluguels[i] != null) {
                    Console.WriteLine(aluguels[i]);
                }
            }

        }
    }
}