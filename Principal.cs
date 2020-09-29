using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  class Principal {
    private static int opcao;

    public static void Main() {
      int opcao;
      Terreno terreninho = new Terreno("Disponível", 1500);
      string disponivel = terreninho.situacao;
      Console.WriteLine(disponivel);
      do {
        Console.WriteLine("Chaves Imobiliaria");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Selecione a opção desejada:");
        Console.WriteLine("1 - Alugar ou Comprar imóvel");
        Console.WriteLine("2 - Realizar consulta");
        // Console.WriteLine("Digite qual consulta deseja realizar:");
        Console.WriteLine("1 - Consultar situação dos imóveis");
        Console.WriteLine("2 - Consultar clientes");
        Console.WriteLine("3 - Consultar locações dos imóveis");
        Console.WriteLine("4 - Sair");
        opcao = int.Parse(Console.ReadLine());
      } while (opcao == 4);
    }
  }
}