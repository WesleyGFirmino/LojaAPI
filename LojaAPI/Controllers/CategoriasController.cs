using LojaApi.Models;
using LojaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LojaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly CategoriaService _service;

    public CategoriasController(CategoriaService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.Listar());
    }

    [HttpPost]
    public IActionResult Post(Categoria categoria)
    {
        _service.Criar(categoria);
        return Created("", categoria);
    }
}