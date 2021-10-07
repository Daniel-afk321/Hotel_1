using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //hospedes que alugarao quartos que é de 1 a 10 quartos  
            Estudante[] vect = new Estudante[10];
            //quartos que serão alugados quantidade 
            Console.WriteLine("Quantos quartos serao alugados");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
             //vai mostrar a ordem de chegada dos hospedes
                Console.WriteLine($"Hospede #{i}");
            //nome do hospede
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
            //Email do hospede
                Console.WriteLine("Email");
                string email = Console.ReadLine();
            //quarto que o hospede vai ficar
                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quarto ocupados");
            // vai mostrar os quartos que os hospedes escolheram e ja estao ocupado
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }


        }
    }
}
