using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Strategy_Pagamentos.Model.Preco;

namespace Strategy_Pagamentos.Model.FormasDePagameto
{
    public class PagamentoCartaoDebito : IFormasDePagamento
    {
        public FormasDePagamentoENUM formaDePagamento => FormasDePagamentoENUM.PagamentoCartaoDebito;
        public decimal PrecoPorFormaDePagamento(PrecoDTO parametros) => parametros.PrecoBase;
    }
}
