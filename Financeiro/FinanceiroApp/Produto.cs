using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceiroApp
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Double Valor { get; set; }
        public Double Quantidade { get; set; }
        public Double Total {
            get {
               
                return Quantidade*Valor;
            }
        }
       
    }
}
