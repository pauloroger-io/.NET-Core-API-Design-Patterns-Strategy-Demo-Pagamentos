using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pagamentos.Model.Preco
{
    public interface IPreco
    {
        decimal PrecoPorFormaDePagamento(PrecoDTO parametros);
    }
}
