namespace Imobiliaria {
  class Terreno: Imovel {
    // private string situacao;
    // private double valor;

    // public string _situacao { get { return this.situacao; } set { this.situacao = value; } }
    // public double _valor { get { return this.valor; } set { this.valor = value; } }

    // public Terreno() {}
    
    // public Terreno(string situacao, double valor) {
    //   this.situacao = situacao;
    //   this.valor = valor;s
    // }

    public override double CalcularIPTU() {
      return 0.03;
    }

    public override string imprimir() {
      string str = string.Format("Terreno: (\n {0},\n {1},\n)\n",
        this._situacao,
        this._valor
      );
      return str;
    }
  }
}