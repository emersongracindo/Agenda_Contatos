using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaContatos.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage="Informe o nome do contato!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o primeiro email do contato!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O Email informado e invalido!")]
        public string Email1 { get; set; }

        [Required(ErrorMessage = "Informe o segundo email do contato!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O Email informado e invalido!")]
        public string Email2 { get; set; }

        [Required(ErrorMessage = "Informe o primeiro fone do contato!")]
        public string Fone1 { get; set; }

        [Required(ErrorMessage = "Informe o segundo fone do contato!")]
        public string Fone2 { get; set; }

        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT id, nome, email1, email2, fone1, fone2 FROM CONTATOS order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Email1 = dt.Rows[i]["Email1"].ToString(),
                    Email2 = dt.Rows[i]["Email2"].ToString(),
                    Fone1 = dt.Rows[i]["Fone1"].ToString(),
                    Fone2 = dt.Rows[i]["Fone2"].ToString()
                };
                lista.Add(item);
            }
            return lista;
        }

        public void Inserir()
        {
            DAL objDAL = new DAL();
            string sql = $"INSERT INTO CONTATOS(NOME, EMAIL1, EMAIL2, FONE1, FONE2) VALUES('{Nome}','{Email1}','{Email2}','{Fone1}','{Fone2}')";
            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
