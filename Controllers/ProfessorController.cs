using System;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
             try
            {
                return Ok("Renato");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }
    }
}