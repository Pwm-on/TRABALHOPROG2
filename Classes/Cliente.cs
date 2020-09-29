namespace Imobiliaria {
  class Cliente : Pessoa {
    private bool liberado;

    public bool _liberado { get { return this.liberado; } set { this.liberado = value; } }

    public Cliente() {}

    public Cliente(bool liberado) {
      this.liberado = liberado;
    }
    
    public override string imprimir() {
      string str = string.Format("Venda: (\n {0}\n)\n",
        this.liberado
      );
      return str;
    }
  }
}