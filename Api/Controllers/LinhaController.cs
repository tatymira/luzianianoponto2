using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Classes;
using Domain.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[linha]")]
    public class LinhaController : ControllerBase
    {

        private readonly ILinhaService _linhaService;

        public LinhaController(ILinhaService linhaService)
        {
            _linhaService = linhaService;
        }

        [HttpPost]
        public void Salvar()
        {
            var linha = new Linha();
            _linhaService.Salvar(linha);
        }
    }
}
