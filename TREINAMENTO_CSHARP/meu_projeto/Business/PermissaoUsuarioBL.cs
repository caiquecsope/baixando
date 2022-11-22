using AutoMapper;
using meu_projeto.Data.Repository;
using meu_projeto.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using Signa.Library.Core;
using Signa.Library.Core.Exceptions;
using Signa.Library.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace meu_projeto.Business
{
    public class PermissaoUsuarioBL
    {
        private readonly IMapper _mapper;
        private readonly PermissaoUsuarioDAO _permissaoUsuarioDAO;
        private readonly int _usuarioId;
        private readonly int _funcaoId;
        private readonly int _grupoUsuarioId;

        public PermissaoUsuarioBL(
            IMapper mapper,
            PermissaoUsuarioDAO permissaoUsuarioDAO
        )
        {
            _mapper = mapper;
            _permissaoUsuarioDAO = permissaoUsuarioDAO;
            _usuarioId = Global.UsuarioId;
            _funcaoId = Global.FuncaoId;
            _grupoUsuarioId = Global.GrupoUsuarioId;
        }


        public PermissaoUsuarioModel Get()
        {
            if (_usuarioId.IsZeroOrNull())
                throw new SignaSqlNotFoundException("Usuário não encontrado");

            var permissoes = _permissaoUsuarioDAO.Get(_usuarioId, _funcaoId);

            if (permissoes == null)
                throw new SignaSqlNotFoundException("Nenhuma permissão encontrada para essa função com este usuário");

            permissoes.Token = CreateToken();

            return _mapper.Map<PermissaoUsuarioModel>(permissoes);
        }

        private string CreateToken()
        {
            var identity = new ClaimsIdentity(
                new[] {
                    new Claim("UserId", _usuarioId.ToString()),
                    new Claim("FuncaoId", _funcaoId.ToString()),
                    new Claim("GrupoUsuarioId", _grupoUsuarioId.ToString()),
                }
            );

            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao + TimeSpan.FromMinutes(Global.TokenMinutes);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao,
                SigningCredentials = Global.SigningCredentials
            });

            return handler.WriteToken(securityToken);
        }
    }
}
