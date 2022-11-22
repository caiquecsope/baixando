using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using wsteste.api.Business;
using wsteste.api.Domain.Entities;

namespace wsteste.api.Data.Repository
{
    public class PessoaTesteDao
    {
        public string Insert(PessoaTesteEntity pessoaTeste)
            var sql = @"
                        update Pessoa
                        Set
                        NOME_FANTASIA = '{pessoaTeste.NOME_FANTASIA}' WHERE PESSOA_ID = {pessoaTeste.PESSOA_ID} ";

            var result = connection.Query<PessoaTesteEntity>(sql);

            var resultSelect = Connection.QueryFirst<PessoaTesteEntity>($"SELECT * FROM Pessoa where PESSOA_ID = {PessoaTeste.PESSOA_ID}");

            return resultSelect;
            
    }

    public IEnumerable<PessoaTesteEntity> Get()
    {
        var sql = @"
                    Select
                    Pessoa_ID as Id,
                    NOME_FANTASIA,
                    CNPJ_CPF
                    FROM
                    Pessoa
                    Where
                    PESSOA_ID = {pessoaTeste.PESSOA_ID} ");
        {
            var result = connection.Query<PessoaTesteEntity>(sql);
            var resultSelect = connection.QueryFirst<PessoaTesteEntity>($"SELECT * FROM Pessoa where PESSOA_ID = {pessoa.PESSOA_ID} ");
        }
        using (var connection = new MySqlConnection("Server=localhost;Database=TESTE;Uid=root;Pwd=1234"))
        {
            return connection.Query<PessoaTesteEntity>(sql);
            return resultSelect;
        }
    }
}
