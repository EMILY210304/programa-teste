using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome ;
            int idade = 17;
            string cidade = "CJO";

            Console.WriteLine("Digite seu nome.");
           nome= Console.ReadLine();
            Console.WriteLine("Digite sua idade.");
            idade =int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade.");
            cidade = Console.ReadLine();
            
            Console.WriteLine("Hello, World");
            Console.WriteLine("Nome: {0}",nome);
            Console.WriteLine("idade: {0}",idade);
            Console.WriteLine("Cidade:{0}",cidade);
            Console.WriteLine("Nime:{0} \n idade: {1} anos \n cidade {2}", nome, idade, cidade);
        }
    }
}
