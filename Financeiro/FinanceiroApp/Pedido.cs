using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceiroApp
{
    class Pedido{
        public int Id { get; set; }
        public DateTime Data { get; set; } 
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public ICollection<Produto> produtos {get; }

        public Double Total { get
            {
                Double total = 0;
                foreach (Produto prod in produtos) {
                    total = +prod.Total;
                }
                return total;
            }
        }
        public Pedido() {
            produtos = new List<Produto>();

        }
        public void AddProduto(Produto produto)
        {
            produtos.Add(produto);
        }
       
    }
}
