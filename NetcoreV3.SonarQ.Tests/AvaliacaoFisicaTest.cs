using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetcoreV3.SonarQ.Apps;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Tests
{
    [TestClass]
    public class AvaliacaoFisicaTest
    {
        private readonly IAvaliacaoFisica app;

        public AvaliacaoFisicaTest()
        {
            this.app = new AvaliacaoFisica();
        }

        [TestMethod]
        public void DeveCalcularImc()
        {
            //Arrange

            //Act
            var imc = this.app.CalcularIMC(190, 90);

            //Assert
            Assert.IsTrue(imc.Equals(1));
        }

        [TestMethod]
        public void DeveCalcularImcErro()
        {
            //Arrange

            //Act
            var imc = this.app.CalcularIMC(190, 90);

            //Assert
            Assert.IsFalse(imc.Equals(1));
        }
    }
}
