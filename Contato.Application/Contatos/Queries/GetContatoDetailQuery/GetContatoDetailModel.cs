using System;
using System.Collections.Generic;
using System.Text;

namespace Contato.Application.Contatos.Queries.GetContatoDetailQuery
{
    public class GetContatoDetailModel
    {
        public string id { get; set; }

        public string nome { get; set; }

        public string canal { get; set; }

        public string valor { get; set; }

        public string obs { get; set; }
    }
}
