namespace Imobiliaria {
  class Casa : Imovel {
    private double areaConstruida;

    public double _areaConstruida { get { return this.areaConstruida; } set { this.areaConstruida = value; } }
    
    // double getValor(double Valor) {
    //   return Valor;
    // }

    public Casa() {}

    public Casa() {
      this.areaConstruida = areaConstruida;
    }

    public virtual string imprimir() {
      string str = String.Format("Casa: (\n {0}\n)\n",
        this._areaConstruida
      );
      return str;
    }

    public override double CalcularIPTU() {
      return 0.55;
    }
  }
}