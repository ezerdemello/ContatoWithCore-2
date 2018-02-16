using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Application.Contatos.Queries.GetContatoDetailQuery
{
    public class GetContatoDetailQuery : IGetContatoDetailQuery
    {
        public GetContatoDetailQuery()
        {

        }

        public Task<GetContatoDetailModel> Execute(string id)
        {
            throw new NotImplementedException();
        }
    }
}
