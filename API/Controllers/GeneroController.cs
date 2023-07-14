using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;


public class GeneroController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;

    public GeneroController(IUnitOfWork _unitOfWork)
    {
        unitOfWork = _unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Genero>>> Get()
    {
        var generos = await unitOfWork.Generos.GetAllAsync();
        return Ok(generos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var genero = await unitOfWork.Generos.GetByIdAsync(id);
        return Ok(genero);
    }

    /* [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(Genero genero)
    {
        _context.Add(genero);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpPost("varios")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(Genero[] generos)
    {
        foreach (Genero genero in generos)
        {
           _context.Add(genero);
            await _context.SaveChangesAsync();
            
        }
        return Ok(); 
    } */

}
