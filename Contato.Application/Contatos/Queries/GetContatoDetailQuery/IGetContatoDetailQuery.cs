using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Application.Contatos.Queries.GetContatoDetailQuery
{
    public interface IGetContatoDetailQuery
    {
        Task<GetContatoDetailModel> Execute(string id);
    }
}
