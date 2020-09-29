using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  class Contrato {}
  class Venda: Contrato {
    private
    double ValorTotal,
    Comissao;
    int TptalParcelas;
    string FormaPagamento;
    Funcionario funcionario;
    Imovel imovel;
    Cliente cliente;

    public Venda() {}

    public Venda(double valorTotal, double comissao, int tptalParcelas, string formaPagamento, Funcionario funcionario, Imovel imovel, Cliente cliente) {
      ValorTotal = valorTotal;
      Comissao = comissao;
      TptalParcelas = tptalParcelas;
      FormaPagamento = formaPagamento;
      this.funcionario = funcionario;
      this.imovel = imovel;
      this.cliente = cliente;
    }
  }
  
  class Aluguel: Contrato {
    double Mensal;
    int QuantidadedeMeses;
    Imovel imovel;
    Funcionario funcionario;
    Cliente cliente;

    public Aluguel(double mensal, int quantidadedeMeses, Imovel imovel, Funcionario funcionario, Cliente cliente) {
      Mensal = mensal;
      QuantidadedeMeses = quantidadedeMeses;
      this.imovel = imovel;
      this.funcionario = funcionario;
      this.cliente = cliente;
    }

    public Aluguel() {}
  }

}