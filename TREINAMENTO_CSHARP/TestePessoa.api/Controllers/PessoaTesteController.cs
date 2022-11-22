using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestePessoa.api.Controllers
{
    
    

        [ApiController]
        [Produces("application/json")]
        [Authorize("bearer")]

        public class PessoaTesteController : Controller
        {
        private readonly PessoaTesteBL _pessoatesteBLL;

        public PessoaTesteController(PessoaTesteBL pessoatesteBLL)
        {
            _pessoatesteBLL = pessoatesteBLL;
        }

        [HttpPost]
    }





}
