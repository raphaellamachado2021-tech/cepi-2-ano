using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_classe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("dados do primeiro funcionario ");
            Console.Write("nome: ");
            f1.Nome=Console.ReadLine();
            Console.WriteLine("salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("dados do segundo funcionario ");
            Console.Write("nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double salario_media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("salario medio = " +salario_media);



        }
    }
}

