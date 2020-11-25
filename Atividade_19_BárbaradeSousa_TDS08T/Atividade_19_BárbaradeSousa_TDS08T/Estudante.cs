namespace Atividade_19_BárbaradeSousa_TDS08T
{
    class Estudante
    {
        // prop tab + tab
        // Encapsulamento - serve para segurança
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        // Construtor
        public Estudante(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": "
                        + Nome + ", "
                        + Email;
        }
    }
}
