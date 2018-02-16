using Contato.Domain.Common;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contato.Domain.Contatos
{
    public class Contato : Entity
    {
        public string nome { get; set; }

        public string canal { get; set; }

        public string valor { get; set; }

        public string obs { get; set; }
    }
}
