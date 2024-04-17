using System;
using System.Globalization;
using C_sharp_classes_attributes_methods_static_members;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto:");

            System.Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            System.Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            System.Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            p.Mostrar();

            System.Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int numero = int.Parse(Console.ReadLine());
            p.Adicionar(numero);
            p.Mostrar();

            System.Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            numero = int.Parse(Console.ReadLine());
            p.Remover(numero);
            p.Mostrar();
        }
    }
}