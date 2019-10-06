using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Strategy_Pagamentos.Model.Preco;

namespace Strategy_Pagamentos.Model.FormasDePagameto
{
    public class PagamentoCartaoCredito : IFormasDePagamento
    {
        public FormasDePagamentoENUM formaDePagamento => FormasDePagamentoENUM.PagamentoCartaoCredito;
        public decimal PrecoPorFormaDePagamento(PrecoDTO parametros) => (parametros.PrecoBase + (parametros.PrecoBase * 0.05m));
    }
}
