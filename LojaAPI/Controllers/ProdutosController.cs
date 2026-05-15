using LojaApi.Models;
using LojaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LojaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoService _service;

    public ProdutosController(ProdutoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.Listar());
    }

    [HttpPost]
    public IActionResult Post(Produto produto)
    {
        _service.Criar(produto);
        return Created("", produto);
    }
}