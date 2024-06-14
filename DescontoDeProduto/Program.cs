using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoDeProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco;
            double desconto;

            Console.WriteLine("Informe o valor do produto"); 
            preco = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (preco >= 200) desconto = preco * 10 / 100;
            else
                desconto = preco * 12.5 / 100; 


            Console.WriteLine("Valor do produto = " +preco+ " desconto = " +desconto);       
            Console.WriteLine("Valor a pagar = "+(preco - desconto));
            Console.ReadKey(); 



        }
    }
}
