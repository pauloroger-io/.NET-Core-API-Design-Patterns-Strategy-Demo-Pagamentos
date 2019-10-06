using Strategy_Pagamentos.Model.FormasDePagameto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.Preco
{
    public class PrecoDTO
    {
        public int ProdutoID { get; set; }
        public FormasDePagamentoENUM FormaDePagamento { get; set; }
        public string DescricaoDaFormaDePagamento { get; set; }
        public decimal PrecoBase { get; set; }
        public decimal PrecoFinal { get; set; }
    }
}
