using Strategy_Pagamentos.Model.Preco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.FormasDePagameto
{
    public class PagamentoBoleto : IFormasDePagamento
    {
        public FormasDePagamentoENUM formaDePagamento => FormasDePagamentoENUM.PagamentoBoleto;
        public decimal PrecoPorFormaDePagamento(PrecoDTO parametros) => (parametros.PrecoBase - (parametros.PrecoBase * 0.15m));

    }
}
