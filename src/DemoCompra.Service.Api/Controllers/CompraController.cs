﻿using DemoCompra.Application.Interfaces;
using DemoCompra.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<CompraViewModel>> Get()
        {
            return await _compraAppService.ObterTodos();
        }

        [HttpPost("compra")]
        public ActionResult CadastrarCompra(CompraViewModel c)
        {
            _compraAppService.AdicionarCompra(c);
            return Ok();
        }

        [HttpPost("atualizar-compra")]
        public ActionResult AtualizarCompra(CompraViewModel c)
        {
            _compraAppService.AdicionarCompra(c);
            return Ok();
        }
    }
}
