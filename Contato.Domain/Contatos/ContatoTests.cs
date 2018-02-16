using MongoDB.Bson;
using System;
using Xunit;

namespace Contato.Domain.Contatos
{
    public class ContatoTests
    {

        private Contato _contato;
        private string _strVal;

        public ContatoTests()
        {
            _contato = new Contato();
        }


        [Fact]
        public void TestSetAndGetId()
        {
            var _id = ObjectId.GenerateNewId();
            _contato.id = _id;
            Assert.Equal(_id, _contato.id);
        }

        [Fact]
        public void TestSetAndGetNome()
        {
            _strVal = "teste";
            _contato.nome = _strVal;
            Assert.Equal(_strVal, _contato.nome);
        }

        [Fact]
        public void TestSetAndGetCanal()
        {
            _strVal = "teste";
            _contato.canal = _strVal;
            Assert.Equal(_strVal, _contato.canal);
        }

        [Fact]
        public void TestSetAndGetValor()
        {
            _strVal = "teste";
            _contato.canal = _strVal;
            Assert.Equal(_strVal, _contato.valor);
        }

        [Fact]
        public void TestSetAndGetObs()
        {
            _strVal = "teste";
            _contato.obs = _strVal;
            Assert.Equal(_strVal, _contato.obs);
        }

    }

}
