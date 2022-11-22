using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wsteste.api.Business;
using wsteste.api.Domain.Models;

namespace wsteste.api.Controllers
{
    [ApiController]
    [Produces("application/json"]
    [Authorize("Bearer")]
    public class PessoaTesteController : Controller
    {
        private readonly PessoaTesteBL _pessoatesteBLL;

        public PessoaController(PessoaBL pessoatesteBLL)
        {
            _pessoatesteBLL = pessoatesteBLL;
        }

        [HttpPost]
        [Route("/pessoateste")]

        public ActionResult<PessoaTesteModel> Insert(PessoaTesteModel pessoateste) => Ok(_pessoatesteBLL.Insert(pessoateste));

        [HttpGet]
        [Route("pessoateste/{Pessoa_ID}")]
        public ActionResult<PessoaTesteModel> GetById(int id) => Ok(_pessoatesteBLL.GetById(id));

        [HttpGet]
        [Route("colaborador")]

        public ActionResult<IEnumerable<PessoaTesteModel>> Get() => Ok(_pessoatesteBLL.Get());
    }
    
       
      
    
}
