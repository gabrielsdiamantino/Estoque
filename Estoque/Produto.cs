using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void SubProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", R$" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade 
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
