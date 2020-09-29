namespace Imobiliaria {
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

    public virtual string imprimir() {
      string str = String.Format("Funcionario: (\n {0},\n {1}\n)\n",
        this.salario,
        this.percComissao
      );
      return str;
    }
  }
}