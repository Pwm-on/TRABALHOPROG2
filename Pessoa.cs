namespace Imobiliaria {
  class Pessoa {
    private string Nome,
    CPF;
    private Endereco endereco;

    public Pessoa() {}
    public Pessoa(string nome, string cPF, Endereco endereco) {
      Nome = nome;
      CPF = cPF;
      this.endereco = endereco;
    }

    public Pessoa(string nome, string cPF) {
      Nome = nome;
      CPF = cPF;
    }
  }
  class Funcionario: Pessoa {
    private double Salario,
    Perc_Comissao;

    public Funcionario() {}

    public Funcionario(double salario, double perc_Comissao) {
      Salario = salario;
      Perc_Comissao = perc_Comissao;
    }
    void CalcularSalario(double comissao, double salario) {
      salario = 5000 + comissao;
    }
  }
  class Cliente: Pessoa {
    private
    bool Liberado;

    public Cliente() {}
    public Cliente(bool liberado) {
      Liberado = liberado;
    }
  }
  class Comissao: Funcionario {
    public double CalcularComissao(double Valor) {
      double comissao = Valor * 0.03;
      return comissao;
    }
  }
}