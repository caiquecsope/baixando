using EMPRESA.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Data.Common;

namespace EMPRESA.Repository
{
    public class PESSOADAO : Controller
    {
       public int Insert(PessoaEntity pessoa)
        {
            var sql = @"
                        Declare @id Int
                        Update Infra_Ids
                        Set
                            @id = Pessoa_Id + 1,
                            Pessoa_Id = Pessoa_Id + 1
                        Insert into Pessoa(Pessoa_Id, Nome, Nome_Fantasia, Pf_Cpf,
                                           Email, Data_Nascimento, Tab_Status_Id)
                        Values (@id, @nome, @nomeFantasia, @cpnjCpf, @email,
                                @dataNascimento, 1)
                        Select @id";
            var param = new
            {
                nome = pessoa.Nome,
                nomeFantasia = pessoa.NomeFantasia,
                cnpjCpf = pessoa.PfCpf,
                email = pessoa.Email,
                dataNascimento = pessoa.DataNascimento
            };
            
            using (var db = Connection)
            {
                return db.QueryFirstOrdefault<int>(sql, param);
            }

        }

        public void Update(PessoaEntity pessoa)
        {
            var sql = @"
                            Update Pessoa
                            Set
                                Nome = @nome,
                                Nome_fantasia = @nomeFantasia,
                                PF_CPF = @cnpjCpf,
                                Email = @email,
                                Data_Nascimento = @dataNascimento
                             Where Pessoa_Id = id";

            var param = new
            {
                id = pessoa.Id,
                nome = new DbString { Value = pessoa.Nome, Length = 250, IsAnsi = true },
                nomeFantasia = new DbString { Value = pessoa.NomeFantasia, Lenght = 250, IsAnsi = true },
                cnpjCpf = new DbString { Value = pessoa.PjCnpj, Length = 19.IsAnsi = true },
                email = new DbString { Value = pessoa.Email, Length = 100, IsAnsi = true },
                dataNascimento = pessoa.DataNascimento

            };

            using (var db = Connection)
            {
                db.Execute(sql, param);
            }
        }
    }
}
