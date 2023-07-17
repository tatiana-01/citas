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

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Genero>> Post(Genero genero)
    {
        this.unitOfWork.Generos.Add(genero);
        await unitOfWork.SaveAsync();
        if(genero == null){
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id=genero.id},genero);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Genero>> Put(int id, [FromBody]Genero genero)
    {

        if(genero == null){
            return NotFound();
        }
            unitOfWork.Generos.Update(genero);
            await unitOfWork.SaveAsync();
            return genero;
        
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var genero = await unitOfWork.Generos.GetByIdAsync(id);
        if(genero == null){
            return NotFound();
        }
        unitOfWork.Generos.Remove(genero);
        await unitOfWork.SaveAsync();
        return NoContent();
    }
}
