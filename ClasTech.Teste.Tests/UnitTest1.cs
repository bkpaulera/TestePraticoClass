using ClasTech.Teste.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClasTech.Teste.Tests
{
    public class Tests
    {
        [TestMethod]
        public void Index()
        {
            var service = new TesteService();

            var lista = service.GetAll();
        }
    }
}