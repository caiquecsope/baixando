﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Signa.Library.Core.Aspnet.Domain.Models;
using System.Collections.Generic;
using wsteste.api.Business;
using wsteste.api.Domain.Models;

namespace wsteste.api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Authorize("Bearer")]
    public class PermissaoUsuarioController : Controller
    {
        private readonly PermissaoUsuarioBL _permissaoUsuarioBLL;

        public PermissaoUsuarioController(PermissaoUsuarioBL permissaoUsuarioBLL)
        {
            _permissaoUsuarioBLL = permissaoUsuarioBLL;
        }

        /// <summary>
        /// Busca permissão do usuário logado na base de dados
        /// </summary>
        /// <response code="200">Permissões cadastradas na base de dados</response>
        /// <response code="404">Nenhuma permissão encontrada na base de dados</response>
        [HttpGet]
        [Route("permissao")]
        public ActionResult<PermissaoUsuarioModel> Get() => Ok(_permissaoUsuarioBLL.Get());


    }
}
