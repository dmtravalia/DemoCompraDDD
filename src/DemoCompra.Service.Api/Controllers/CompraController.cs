using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCompra.Application.Interfaces;
using DemoCompra.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoCompra.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ILogger<CompraController> _logger;
        private readonly ICompraAppService _compraAppService;

        public CompraController(ILogger<CompraController> logger,
            ICompraAppService compraAppService)
        {
            _logger = logger;
            _compraAppService = compraAppService;
        }


        [HttpGet]
        public IEnumerable<CompraViewModel> Get()
        {
            //Task<IEnumerable<CompraViewModel>> ll = _compraAppService.ObterTodos();

            //CompraViewModel c = new CompraViewModel();
            //c.Id = Guid.NewGuid();
            //c.Quantidade = 10;
            //c.Descricao = "Castanha";

            //_compraAppService.AdicionarCompra(c);

            //List<CompraViewModel> l = new List<CompraViewModel>();
            //l.Add(c);
            //return l.ToArray();


            return _compraAppService.ObterTodos().ToArray();
        }

        [HttpPost]
        public ActionResult CadastrarVenda(CompraViewModel c)
        {
            _compraAppService.AdicionarCompra(c);
            return Ok();
        }
    }
}
