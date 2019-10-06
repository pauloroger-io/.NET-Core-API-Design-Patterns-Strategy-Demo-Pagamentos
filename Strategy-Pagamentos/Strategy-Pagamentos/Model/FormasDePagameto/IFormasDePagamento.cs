using Strategy_Pagamentos.Model.Preco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.FormasDePagameto
{
    public interface IFormasDePagamento
    {
        FormasDePagamentoENUM formaDePagamento { get; }
        public decimal PrecoPorFormaDePagamento(PrecoDTO parametros);
    }
}
