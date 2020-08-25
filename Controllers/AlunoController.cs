using System;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebApi.Data;

namespace SmartSchool_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController: ControllerBase
    {
        public AlunoController(IRepository repo){}
        
        [HttpGet]
        public IActionResult Get(){
            
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}