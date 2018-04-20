using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            

            Idades i = new Idades();

            
            Console.WriteLine("1 - Cadastrar Idade ");
            Console.WriteLine("2 - Calcular media ");
            op = int.Parse(Console.ReadLine());
            do
            {

                switch (op)
                {
                    case 1:


                        Console.WriteLine("--------------menu-------------");
                        Console.WriteLine("1 - Cadastrar Idade ");
                        Console.WriteLine("2 - Calcular media ");
                        Console.WriteLine("0 - Sair ");
                        op = int.Parse(Console.ReadLine());
                        break;
                }
            } while (op != 0);
        }
    }
}
