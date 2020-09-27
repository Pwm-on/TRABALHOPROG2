namespace TRABALHOPROG2
{
    class Pessoa
    {
        private string Nome, CPF;
        private Endereco endereco;

        public Pessoa()
        {
        }
        public Pessoa(string nome, string cPF, Endereco endereco)
        {
            Nome = nome;
            CPF = cPF;
            this.endereco = endereco;
        }
    }
    class Funcionario : Pessoa
    {
        private double Salario, Perc_Comissao;

        public Funcionario()
        {
        }

        public Funcionario(double salario, double perc_Comissao)
        {
            Salario = salario;
            Perc_Comissao = perc_Comissao;
        }
    }
    class Cliente : Pessoa
    {
        private 
            bool Liberado;

        public Cliente()
        {
        }
        public Cliente(bool liberado)
        {
            Liberado = liberado;
        }
    }
    class Comissao : Funcionario
    {
        public double CalcularComissao (double Valor)
        {
            return Valor;
        }
    }
}
