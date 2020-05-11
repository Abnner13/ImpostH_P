using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise_H_P.Entities;

namespace Exercise_H_P
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuente> list = new List<Contribuente>();

            System.Console.Write("Entra o Número de Contribuentes:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine($"Numero de Contribuentes #{i + 1} dados:");
                System.Console.Write("Fisica ou Juridica(f/j)?  ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'f' || ch == 'F')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("RendaAnual: ");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Gastos com Saúde: ");
                    double Saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(name, renda, Saude));

                }
                else if(ch == 'j'|| ch == 'J')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("RendaAnual: ");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Número de Funcionários: ");
                    int funcionario = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(name, renda, funcionario));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Imposto Pago");

            double sum = 0.0;
            foreach (Contribuente tp in list)
            {
                double tax = tp.Imposto();
                Console.WriteLine(tp.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TAXAS TOTAIS: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

