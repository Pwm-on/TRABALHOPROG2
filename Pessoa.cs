namespace Imobiliaria {
  class Pessoa {
    private string nome, cpf;
    private Endereco endereco;

    public Pessoa() {}
    public Pessoa(string nome, string cpf, Endereco endereco) {
      this.nome = nome;
      this.cpf = cpf;
      this.endereco = endereco;
    }

    public Pessoa(string nome, string cpf) {
      this.nome = nome;
      this.cpf = cpf;
    }
  }

  class Funcionario : Pessoa {
    private double salario, percComissao;

    public Funcionario() {}

    public Funcionario(double salario, double percComissao) {
      this.salario = salario;
      this.percComissao = percComissao;
    }
    void CalcularSalario(double comissao, double salario) {
      salario = 5000 + comissao;
    }
  }

  class Cliente : Pessoa {
    private bool liberado;

    public Cliente() {}
    public Cliente(bool liberado) {
      this.liberado = liberado;
    }
  }
  
  class Comissao : Funcionario {
    public double CalcularComissao(double valor) {
      return valor * 0.03;
    }
  }
}