using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetcoreV3.SonarQ.Apps;
using NetcoreV3.SonarQ.Apps.Interfaces;


namespace NetcoreV3.SonarQ.Tests
{
    [TestClass]
    public class GerarCodigoCadastroTest
    {
        private readonly IGerarCodigoCadastro app;

        public GerarCodigoCadastroTest()
        {
            //this.app = new GerarCodigoCadastro();
        }

        [TestMethod]
        public void RetornaCodigoPadrao1()
        {
            //Arrange

            //Act
            //var codigo = this.app.Gerar();

            //Assert
            //Assert.IsTrue(codigo == "ABC-123999");
        }

        [TestMethod]
        public void RetornaCodigoPadrao2()
        {
            //Arrange

            //Act
            //var codigo = this.app.Gerar();

            //Assert
            //Assert.IsTrue(codigo == "ABC-123999");
        }
    }
}
