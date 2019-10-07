using Strategy_Pagamentos.Model.FormasDePagameto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.Preco
{
    public class Preco : IPreco
    {
        private readonly IEnumerable<IFormasDePagamento> _formasDePagamento;

        public Preco(IEnumerable<IFormasDePagamento> formasDePagamento)
        {
            _formasDePagamento = formasDePagamento;
        }

        public decimal PrecoPorFormaDePagamento(PrecoDTO parametros)
        {
            var forma = _formasDePagamento.FirstOrDefault(x => x.formaDePagamento == parametros.FormaDePagamento);
            var valor = forma.PrecoPorFormaDePagamento(parametros);

            return valor;
        }

        public decimal PrecoBasePorID(PrecoDTO parametros)
        {
            return MockPrecos().Where(x => x.ProdutoID == parametros.ProdutoID).Select(x=> x.PrecoBase).FirstOrDefault();
        }

        public List<PrecoDTO> MockPrecos()
        {
            List<PrecoDTO> precos = new List<PrecoDTO>();

            PrecoDTO precoDTO1 = new PrecoDTO();
            precoDTO1.ProdutoID = 1;
            precoDTO1.PrecoBase = 1000;
            precos.Add(precoDTO1);

            PrecoDTO precoDTO2 = new PrecoDTO();
            precoDTO2.ProdutoID = 2;
            precoDTO2.PrecoBase = 1500;
            precos.Add(precoDTO2);

            PrecoDTO precoDTO3 = new PrecoDTO();
            precoDTO3.ProdutoID = 3;
            precoDTO3.PrecoBase = 2000;
            precos.Add(precoDTO3);

            return precos;
        }
    }
}
