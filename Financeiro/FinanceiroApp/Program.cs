using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace FinanceiroApp {

    class Program {
        public static void Main(string[] args) {
            
            string[] lines = System.IO.File.ReadAllLines(args.Length == 0? @"ModeloLayoutSisFAT.txt":args[0]);
            List<Pedido> pedidos = new List<Pedido>();


            for (int i = 0; i < lines.Length; i++) {
                if (lines[i] == "CABEC:") {
                    Pedido pedido = new Pedido();
                    pedido.Id = Int32.Parse(lines[++i].Substring(0, 6));
                    pedido.Data = DateTime.ParseExact(lines[i].Substring(6, 8), "ddMMyyyy",
                                       CultureInfo.InvariantCulture);
                    pedido.Nome = lines[i].Substring(14, 31);
                    pedido.Cnpj = lines[i].Substring(45, 14);
                    i++;
                   
                    if (lines[i] == "ITENS:") {
                        Produto produto = new Produto();
                        while (lines[i + 1] != "CABEC:") {

                            produto.Id = Int32.Parse(lines[++i].Substring(0, 3));
                            produto.Descricao = lines[i].Substring(3, 49);
                            produto.Valor = Double.Parse(lines[i].Substring(52, 11));
                            produto.Quantidade = Double.Parse(lines[i].Substring(63, 9));
                            pedido.AddProduto(produto);
                            
                           
                            if(i == lines.Length - 1) {
                                pedidos.Add(pedido);
                                i--;
                                break;
                            }
                            if(lines[i + 1] == "CABEC:") { pedidos.Add(pedido); }
                            
                        }
                        
                    }
                }
            }


               

                string[] saida = new String[pedidos.Count()];
                int count = 0;
                foreach (Pedido ped in pedidos) {
                    saida[count++] = ped.Id + ";" + ped.Data+ ";" + ped.Cnpj + ";R;" + ped.Total + ";0001";
                }
                System.IO.File.WriteAllLines(args.Length < 2 ? @"ModeloLayoutSisFIN.txt" : args[1], saida);

            

            // Suspend the screen.
            Console.ReadLine();
            
        }
    }
}
