using System.Globalization;
namespace EstoqueDeProdutos
{
    class Produto
    {
        // Atributos 
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor 
        /* Utilizado para iniciar valores dos atributos, permitir ou obrigar que o objeto receba dados */
        /* Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão Produto p = new Produto()*/

        // Exemplo this : Diferenciar atributos de variáveis locais
        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
        // Construtor padrão 
        public Produto()
        {

        }

        // Sobrecarga 
        /* Recurso que a classe possui de oferecer mais de uma operação com o mesmo nome, porem com diferentes listas e parâmetros */
        /* É uma forma de iniciar classes com valores específicos */
        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            Quantidade = 5;
        }

        // Método
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        // Métodos que não retornam valor
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        // Para a saída de dados
        public override string ToString()
        {
            return Nome +
                ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}