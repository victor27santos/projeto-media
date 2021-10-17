using System;

namespace projeto_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;
            double media;
            Console.WriteLine("DIGITE A PRIMEIRA NOTA : ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE A SEGUNDA NOTA :");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("ALUNO APROVADO");
            }
            else
            {
                Console.WriteLine("ALUNO REPROVADO");
            }
            Console.ReadKey();
        }
    }
}
