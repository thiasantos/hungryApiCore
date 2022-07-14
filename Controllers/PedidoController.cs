using HungryApiCore.Domain.Interfaces.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hungryApiCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoServico _pedidoServico;
        public PedidoController(IPedidoServico pedidoServico)
        {
            _pedidoServico = pedidoServico;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var retorno = _pedidoServico.Listar();

            return Ok();
        }
    }
}
