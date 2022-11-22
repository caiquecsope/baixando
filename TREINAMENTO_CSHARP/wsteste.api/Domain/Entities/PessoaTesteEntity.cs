using Microsoft.AspNetCore.Mvc;

namespace wsteste.api.Domain.Entities
{
    public class PessoaTesteEntity 
    {
        public string NOME_FANTASIA { get; set; }
        public string CNPJ_CPF { get; set; }
        public int PESSOA_ID { get; set; }
    }
}
