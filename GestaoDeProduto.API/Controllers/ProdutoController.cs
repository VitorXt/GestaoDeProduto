using GestaoDeProduto.Application.Interfaces;
using GestaoDeProduto.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProduto.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult Post(NovoProdutoViewModel novoProdutoViewModel)
        {

            _produtoService.Adicionar(novoProdutoViewModel); 

            return Ok();
        }
    }
}
