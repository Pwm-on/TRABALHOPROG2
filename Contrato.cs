using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  class Contrato {}
  class Venda: Contrato {
    private double valorTotal, comissao;
    private int totalDeParcelas;
    private string formaPagamento;
    private Funcionario funcionario;
    private Imovel imovel;
    private Cliente cliente;

    public Venda() {}

    public Venda(double valorTotal, double comissao, int totalDeParcelas, string formaPagamento, 
    Funcionario funcionario, Imovel imovel, Cliente cliente) {
      this.valorTotal = valorTotal;
      this.comissao = comissao;
      this.totalDeParcelas = totalDeParcelas;
      this.formaPagamento = formaPagamento;
      this.funcionario = funcionario;
      this.imovel = imovel;
      this.cliente = cliente;
    }
  }
  
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

    public Aluguel() {}
  }

}