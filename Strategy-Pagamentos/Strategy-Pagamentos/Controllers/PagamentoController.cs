using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Strategy_Pagamentos.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        [HttpGet("{id}")]
        public string PrecoPorFormaDePagamento(int id)
        {
            return "value";
        }
    }
}