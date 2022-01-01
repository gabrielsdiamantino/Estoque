
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("Cadastre o primeiro produto");
            Console.Write("Nome do produto: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Quantidade: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());
            Console.Write("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Informações do Produto: " + produto1.ToString());

            Console.Write("Digite a quantidade de produtos que deseja adicionar: ");
            int adcProduto = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(adcProduto);

            Console.Write("Digite a quantidade de produtos que deseja subtrair: ");
            int subtrair = int.Parse(Console.ReadLine());
            produto1.SubProdutos(subtrair);

            Console.Write("Informações do Produto: " + produto1.ToString());

            
            Produto produto2 = new Produto();

            Console.WriteLine("Cadastre o segundo produto");
            Console.WriteLine("Nome do produto: ");
            produto1.Nome = Console.ReadLine();
            Console.WriteLine("Quantidade: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informações do Produto: " + produto1.ToString());

            Console.WriteLine("Digite a quantidade de produtos que deseja adicionar: ");
            int adcProduto2 = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(adcProduto2);

            Console.WriteLine("Digite a quantidade de produtos que deseja subtrair: ");
            int subtrair2 = int.Parse(Console.ReadLine());

            produto2.SubProdutos(subtrair2);

            Console.WriteLine("Informações do Produto: " + produto2.ToString());
        }
    }
}
