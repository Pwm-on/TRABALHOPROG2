namespace Imobiliaria {
  public class Apartamento : Imovel {
    private string condominio;
    private int andar;

    public string _condominio { get { return this.condominio; } set { this.condominio = value; } }
    public int _andar { get { return this.andar; } set { this.andar = value; } }

    public Apartamento() {}

    public Apartamento(string condominio, int andar) {
      this.condominio = condominio;
      this.andar = andar;
    }

    public override string imprimir() {
      string str = string.Format("Apartamento: (\n {0},\n {1}\n)\n",
        this._condominio,
        this._andar
      );
      return str;
    }
    
    public override double CalcularIPTU() {
      return 0.02;
    }
  }
}