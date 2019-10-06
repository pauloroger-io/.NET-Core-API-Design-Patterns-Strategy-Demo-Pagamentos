using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.FormasDePagameto
{
    public enum FormasDePagamentoENUM
    {
        PagamentoBoleto = 1,
        PagamentoCartaoDebito = 2,
        PagamentoCartaoCredito = 3
    }
}
