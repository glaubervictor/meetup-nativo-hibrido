using Microsoft.AspNetCore.Mvc;
using NativoApi.Models;

namespace NativoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var pessoa = new Pessoa();
            return Ok(new { pessoas = pessoa.ObtenhaPessoas() });
        }
    }
}
