﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_projeto.Domain.Models
{
    public class PermissaoUsuarioModel
    {
        public bool FlagPermissaoAcesso { get; set; }
        public bool FlagPermissaoExclusao { get; set; }
        public bool FlagPermissaoGravacao { get; set; }
        public bool FlagPermissaoImpressao { get; set; }
        public string Token { get; set; }
    }
}
