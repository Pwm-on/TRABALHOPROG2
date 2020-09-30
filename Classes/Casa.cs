namespace Imobiliaria {
  class Casa : Imovel {
    private double areaConstruida;

    public double _areaConstruida { get { return this.areaConstruida; } set { this.areaConstruida = value; } }
    
    // double getValor(double Valor) {
    //   return Valor;
    // }

    public Casa() {}

    public Casa(double areaConstruida) {
      this.areaConstruida = areaConstruida;
    }

    public override string imprimir() {
      string str = string.Format("Casa: (\n {0},\n {1},\n {2},\n {3},\n {4},\n {5}\n)\n",
        this._areaConstruida,
        this._quadra,
        this._lote,
        this._situacao,
        this._area,
        this._valor
      );
      return str;

    }

    public override double CalcularIPTU() {
      return 0.55;
    }
  }
}