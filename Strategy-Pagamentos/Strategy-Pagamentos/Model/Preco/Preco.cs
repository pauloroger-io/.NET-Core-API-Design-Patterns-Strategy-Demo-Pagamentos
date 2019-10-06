using Strategy_Pagamentos.Model.FormasDePagameto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.Preco
{
    public class Preco : IPreco
    {
        private readonly IEnumerable<IFormasDePagamento> _operacao;

        public Preco(IEnumerable<IFormasDePagamento> operacao)
        {
            _operacao = operacao;
        }

        public decimal PrecoPorFormaDePagamento(PrecoDTO parametros)
        {
            var oper = _operacao.FirstOrDefault(x => x.formaDePagamento == parametros.FormaDePagamento);
            var valor = oper.PrecoPorFormaDePagamento(parametros);

            return valor;
        }
    }
}
