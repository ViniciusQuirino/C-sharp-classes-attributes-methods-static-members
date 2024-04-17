using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace C_sharp_classes_attributes_methods_static_members
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome} - Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)} - Quantidade: {Quantidade} - VALOR TOTAL: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Adicionar(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void Remover(int quantidade)
        {
            Quantidade -= quantidade;
        }

    }
}