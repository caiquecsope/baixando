using meu_projeto.Business;
using meu_projeto.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_projeto.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Authorize("Bearer")]
    //[AllowAnonymous]
    public class ExcelController : Controller
    {
        private readonly ExcelBL _excelBLL;

        public ExcelController(ExcelBL excelBLL)
        {
            _excelBLL = excelBLL;
        }

        [HttpPost]
        [Route("excel")]
        public ActionResult<string> GerarExcel(ExcelModel dadosPlanilha) => Ok(_excelBLL.GerarExcel(dadosPlanilha));
    }
}

