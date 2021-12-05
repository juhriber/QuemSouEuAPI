using Microsoft.AspNetCore.Mvc;
using QuemSouEuAPI.Models;

namespace QuemSouEuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuemSouEuController : ControllerBase
    {
        [HttpGet]
        public PessoaModel Get()
        {
            PessoaModel eu = new PessoaModel();

            eu.Nome = "Juliana";
            eu.Sobrenome = "Ribeiro";
            url= "https://github.com/juhriber";
            eu.UsuarioGitHub = "juhriber";

            return eu;
        }
    }
}