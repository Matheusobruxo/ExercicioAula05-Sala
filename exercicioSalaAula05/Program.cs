using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioSalaAula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string nome;
            string cnh;

            Console.WriteLine("--------Bem vindo ao Detran--------\n\n");
            Console.WriteLine("Digite a sua idade:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nVocê tem {age} anos\n");
            if (age >= 18)
            {
                Console.WriteLine("**Você pode tirar a sua CNH!**\n");
                Console.WriteLine("Você ja tem CNH? (S/N)");
                cnh = Console.ReadLine();
                if (cnh == "S")
                {
                    Console.WriteLine("Então você deve renovar a CNH\n");
                }
                else if (cnh == "N")
                {
                    Console.WriteLine("Você ESTÁ TIRANDO a sua primeira carteira de motorista, passa 5k pro pai\n");

                }
                else if (cnh == "")
                {
                    Console.WriteLine("Digite algo conforme os exemplos da proxima vez meu nobre! \n (S/N)");
                }
                
            
            }
            else
            {
                Console.WriteLine("Espere mais alguns anos PIVETE!!\n\n");
            }
            Console.ReadKey();
            Main(null);

        }
    }
}
