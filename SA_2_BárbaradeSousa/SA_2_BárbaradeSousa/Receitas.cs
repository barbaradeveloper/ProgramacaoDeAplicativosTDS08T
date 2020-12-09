using System.Globalization;
namespace SA_2_BárbaradeSousa
{
    class Receitas
    {
        public string Nome_Da_Receita { get; set; }
        public int Tempo_De_Preparacao { get; set; }
        public double Valor_Receita { get; set; }
        public int Grau_De_Dificuldade { get; set; }
        public int Numero_De_Pessoas { get; set; }
        public int Categoria { get; set; }
        public string Descricao_De_Preparacao { get; set; }
       


        public Receitas(string nome_da_receita, int tempo_de_preparacao, double valor_receita, int grau_de_dificuldade, int numero_de_pessoas, int categoria,
            string descricao_de_preparacao )
        {
            Nome_Da_Receita = nome_da_receita;
            Tempo_De_Preparacao = tempo_de_preparacao;
            Valor_Receita = valor_receita;
            Grau_De_Dificuldade = grau_de_dificuldade;
            Numero_De_Pessoas = numero_de_pessoas;
            Categoria = categoria;
            Descricao_De_Preparacao = descricao_de_preparacao;
           

        }
        public override string ToString()
        {
            return "Nome da receita: " + Nome_Da_Receita +
             "\n Tempo de Preparação: " + Tempo_De_Preparacao +
             "\n Valor Estimado: " + Valor_Receita.ToString("F2" , CultureInfo.InvariantCulture) + 
             "\n Grau de dificuldade: " + Grau_De_Dificuldade +
             "\n Numero de Pessoas: " + Numero_De_Pessoas +
             "\n Categoria: " + Categoria +
             "\n Descrição de preparação: " + Descricao_De_Preparacao +
             "\n __________________________________________________";

        }

    }
}
