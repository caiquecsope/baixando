using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Collections;
using wsteste.api.Data.Repository;
using wsteste.api.Domain.Models;

namespace wsteste.api.Business
{
    public class PessoaTesteBL
    {
        private readonly IMapper _mapper;
        private readonly PessoaTesteDao _pessoaTesteDao;

        public PessoaTesteBL(
            IMapper mapper, PessoaTesteDao pessoaTesteDao)
        {
            _mapper = mapper;
            _pessoaTesteDao = pessoaTesteDao;
        }

        public PessoaTesteModel Insert(PessoaTesteModel pessoaTeste)
        {
            int id = 0;
            var entidade = _mapper.Map<PessoaTesteEntity>(pessoaTeste)

            if (pessoaTeste.PESSOA_ID.IsZeroOrNull())
            {
                id = _pessoaTesteDao.Insert(entidade);
            }
            else
            {
                id = pessoaTeste.PESSOA_ID;
                _pessoaTesteDao.Update(entidade);
            }
            return GetById(id);
        }

        public PessoaTesteModel GetById(int id)
        {
            var pessoaTeste = _pessoaTesteDao.GetById(id);

            if (pessoaTeste == null)
            {
                throw new SignaSqlNotFoundException("Nenhuma pessoa encontrada com esse id");
            }

            return _mapper.Map<PessoaTesteModel>(pessoaTeste);
        }

        public IEnumerable<PessoaTesteModel> Get()
        {
            var results = _pessoaTesteDao.Get();
            
            if (results.IsNullOrEmpty())
            {
                throw new SignaSqlNotFoundException("Nenhuma pessoa encontrada");
            }

            return _mappper.Map<IEnumerable<PessoaTesteModel>>(results);
        }

       
    }
}
