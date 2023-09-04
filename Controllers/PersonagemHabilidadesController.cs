using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using RpgApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonagemHabilidadesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{personagemId}")]
        public async Task<IActionResult> GetPersonagens(int personagemId)
        {
            try
            {
                List<PersonagemHabilidade> lista = await _context.PersonagemHabilidades
                    .Where(phBusca => phBusca.PersonagemId == personagemId).ToListAsync();

                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetHabilidades")]
        public async Task<IActionResult> GetHabilidades()
        {
            try
            {
                List<Habilidade> habilidades = await _context.Habilidades.ToListAsync(); 
                return Ok(habilidades);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidade)
        {
            try
            {
                Personagem personagem = await _context.Personagens
                    .Include(p => p.Arma)
                    .Include(p => p.PersonagemHabilidades).ThenInclude(ps => ps.Habilidade)
                    .FirstOrDefaultAsync(p => p.Id == novoPersonagemHabilidade.PersonagemId);

                if (personagem == null)
                {
                    throw new System.Exception("Personagem não encontrado para o Id Informado");
                }

                Habilidade habilidade = await _context.Habilidades.FirstOrDefaultAsync(h => h.Id == novoPersonagemHabilidade.HabilidadeId);

                if(habilidade == null)
                    throw new System.Exception("Habilidade não encontrada");

                PersonagemHabilidade ph = new PersonagemHabilidade();
                ph.Personagem = personagem;
                ph.Habilidade = habilidade;
                await _context.PersonagemHabilidades.AddAsync(ph);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DeletePersonagemHabilidade")]
        public async Task<IActionResult> Delete(PersonagemHabilidade personagem)
        {
            try
            {
                PersonagemHabilidade personagemHabilidade = await _context.PersonagemHabilidades
                .FirstOrDefaultAsync(ph => ph.PersonagemId == personagem.PersonagemId && ph.HabilidadeId == personagem.HabilidadeId);
            
                _context.PersonagemHabilidades.Remove(personagemHabilidade);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}