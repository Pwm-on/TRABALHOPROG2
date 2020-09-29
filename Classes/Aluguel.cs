namespace Imobiliaria {
  class Aluguel : Contrato {
    double mensal;
    int quantidadeDeMeses;
    Imovel imovel;
    Funcionario funcionario;
    Cliente cliente;

    public Aluguel(double mensal, int quantidadeDeMeses, Imovel imovel, 
    Funcionario funcionario, Cliente cliente) {
      this.mensal = mensal;
      this.quantidadeDeMeses = quantidadeDeMeses;
      this.imovel = imovel;
      this.funcionario = funcionario;
      this.cliente = cliente;
    }

    public virtual string imprimir() {
      string str0 = funcionario.imprimir();
      string str1 = imovel.imprimir();
      string str2 = cliente.imprimir();
      string str = String.Format("Aluguel: (\n {0},\n {1},\n {2},\n {3},\n {4},\n {5}\n)\n",
        this._mensal,
        this._quantidadeDeMeses,
        str0,
        str1,
        str2
      );
      return str;
    }
    
    public Aluguel() {}
  }
}