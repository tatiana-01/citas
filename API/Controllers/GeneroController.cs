using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


    public class GeneroController : BaseApiController
    {
        private readonly CitasContext _context;
        public GeneroController (CitasContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Genero>>> Get()
        {
         var generos = await _context.Generos.ToListAsync();
         return Ok(generos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
         var genero = await _context.Generos.FindAsync(id);
         return Ok(genero);
        }
    }
