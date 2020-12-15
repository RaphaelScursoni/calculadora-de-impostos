using System;
using System.Globalization;
using System.Collections.Generic;
namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Pessoa> list = new List<Pessoa>();

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/n) ");
                string pessoa = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(pessoa == "i")
                {
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(gastoSaude, name, ganhoAnual));

                }else if (pessoa == "c")
                {
                    Console.Write("Number of Employees: ");
                    int nFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nFuncionarios, name, ganhoAnual));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p.APessoa());
            }
        }
    }
}
