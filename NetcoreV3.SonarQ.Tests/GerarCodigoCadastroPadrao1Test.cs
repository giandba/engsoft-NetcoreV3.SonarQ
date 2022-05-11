using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NetcoreV3.SonarQ.Apps;
using NetcoreV3.SonarQ.Apps.Factories;
using NetcoreV3.SonarQ.Apps.Interfaces;


namespace NetcoreV3.SonarQ.Tests
{
    [TestClass]
    public class GerarCodigoCadastroTest
    {
        private readonly Mock<IGerarCodigoRandomico> gerarCodigoRandomicoMock;
        private readonly IGerarCodigoCadastro app;

        public GerarCodigoCadastroTest()
        {
            this.gerarCodigoRandomicoMock = new Mock<IGerarCodigoRandomico>();

            this.app = new GerarCodigoCadastroPadrao1(this.gerarCodigoRandomicoMock.Object);
        }

        [TestMethod]
        public void RetornaCodigoPadrao1()
        {
            //Arrange
            this.gerarCodigoRandomicoMock.Setup(x=>x.GerarCodigo()).Returns(123999);

            //Act
            var codigo = this.app.Gerar();

            //Assert
            Assert.IsTrue(codigo == "ABC-123999");
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
