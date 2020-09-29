namespace Imobiliaria {
  class Cliente : Pessoa {
    private bool liberado;

    public bool _liberado { get { return this.liberado; } set { this.liberado = value; } }

    public Cliente() {}

    public Cliente(bool liberado) {
      this.liberado = liberado;
    }
    
    public virtual string imprimir() {
      string str = String.Format("Venda: (\n {0}\n)\n",
        this.liberado
      );
      return str;
    }
  }
}