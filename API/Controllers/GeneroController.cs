using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;


public class GeneroController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GeneroController(IUnitOfWork _unitOfWork,IMapper mapper)
    {
        unitOfWork = _unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<List<GeneroDTO>> Get()
    {
        var generos = await unitOfWork.Generos.GetAllAsync();
        return this.mapper.Map<List<GeneroDTO>>(generos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<GeneroDTO>> Get(int id)
    {
        var genero = await unitOfWork.Generos.GetByIdAsync(id);
        return this.mapper.Map<GeneroDTO>(genero);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(GeneroDTO generoCreacion)
    {
        var genero=mapper.Map<Genero>(generoCreacion);
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
    public async Task<ActionResult<Genero>> Put(int id, [FromBody]GeneroDTO generoEdicion)
    {
        var genero=mapper.Map<Genero>(generoEdicion);
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
