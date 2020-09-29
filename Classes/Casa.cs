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
      string str = string.Format("Casa: (\n {0}\n)\n",
        this._areaConstruida
      );
      return str;
    }

    public override double CalcularIPTU() {
      return 0.55;
    }
  }
}