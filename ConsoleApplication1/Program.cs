using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        DateTime dt = DateTime.Parse(Console.ReadLine());

        

        Console.WriteLine(CalculaIdade(dt).ToString() + "anos");
        Console.ReadKey();

        
        }

        public static int CalculaIdade(DateTime DataNascimento)
        {
            int anos = DateTime.Now.Year - DataNascimento.Year;

            if(DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month 
            && DateTime.Now.Day < DataNascimento.Day))
            {
                anos--;
            }

            return anos;
        }
 
    }
}
