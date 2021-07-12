using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aula1
    {
        public static void Executar()
        {
            int idade = 0;
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Olá, {nome}. Qual a sua idade: ");

            while (idade == 0)
            {
                try
                {
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tente novamente");
                }
            }

            Console.Write($"Olá, {nome}. Sua idade é {idade} ");
            Console.ReadLine();
        }
    }
}
