namespace Imobiliaria {
  class Terreno: Imovel {
    public string situacao;
    public double valor;
    public Terreno() {}
    
    public Terreno(string situacao, double valor) : base(situacao, valor) {}

    public override double CalcularIPTU() {
      return 0.03;
    }

    public virtual string imprimir() {
      string str = String.Format("Pessoa (\n {0},\n {1},\n)\n",
        this._nome,
        this._cpf
      );
      return str;
    }
  }
}