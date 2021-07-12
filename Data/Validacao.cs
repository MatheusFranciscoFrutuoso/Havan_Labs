using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data

{
    public class Validacao
    {
        public static string validaStringEmBranco()
        {
            string dado = String.Empty;

            dado = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(dado))
            {
                dado = Console.ReadLine().Trim();
                Console.Write("Valor invalido! Digite novamente: ");
            }
            return dado;
        }

        public static int ValidaInteiros()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dados incorretos! Digite novamente");
                }
            } while (true);
        }

    }
}
