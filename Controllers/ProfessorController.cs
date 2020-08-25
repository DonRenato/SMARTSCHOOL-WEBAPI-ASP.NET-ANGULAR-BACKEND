using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebApi.Data;
using SmartSchool_WebApi.Models;

namespace SmartSchool_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController: ControllerBase
    {
        private readonly IRepository _repo;

        public ProfessorController(IRepository repo)
        {   
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
             try
            {
                var result = await _repo.GetAllProfessoresAsync(false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }

         [HttpGet("{profId}")]
        public async Task<IActionResult> GetByProfessorId(int profId)
        {
             try
            {
                var result = await _repo.GetProfessorAsyncById(profId, true);
                if(result == null) return NotFound("professor não encontrado");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }

        [HttpGet("ByAluno/{alunoId}")]
        public async Task<IActionResult> GetProfessoresAsyncByAlunoId(int alunoId)
        {
             try
            {
                var result = await _repo.GetProfessoresAsyncByAlunoId(alunoId, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }

        [HttpPost]
        public async Task<IActionResult> Post(Professor model)
        {    
            try
            {
                _repo.Add(model);
                
                if(await _repo.SaveChangesAsync()){
                    return Ok(model);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

         [HttpPut("{professorId}")]
        public async Task<IActionResult> Update(int professorId, Professor model)
        {    
            try
            {
               var prof = await _repo.GetProfessorAsyncById(professorId, false);

               if(prof == null) return NotFound("professor não encontrado");

               _repo.Update(model);
                
               if(await _repo.SaveChangesAsync())
               {
                    return Ok(model);
               }
    
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{professorId}")]
        public async Task<IActionResult> Delete(int professorId)
        {    
            try
            {
               var professor = await _repo.GetProfessorAsyncById(professorId, false);

              if(professor == null) return NotFound("professor não encontrado");

               _repo.Delete(professor);
                
               if(await _repo.SaveChangesAsync())
               {
                    return Ok();
               }
    
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

    }

    
}