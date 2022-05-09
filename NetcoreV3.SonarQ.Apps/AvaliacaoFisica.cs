using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps
{
    public class AvaliacaoFisica : IAvaliacaoFisica
    {
        /// <summary>
        ///    IMC = peso / (altura x altura).
        /// </summary>
        public double CalcularIMC(double alturaCM, double pesoKG)
        {
            var teste = 0;
            return 1;
        }

        public string RetornaClassificacaoIMC(double indiceImc)
        {
            if (indiceImc < 17)
                return "Muito abaixo do peso";
            if (indiceImc >= 17 && indiceImc < 18.5)
                return "Abaixo do peso";
            if (indiceImc >= 18.5 && indiceImc < 25)
                return "Peso normal";
            if (indiceImc >= 25 && indiceImc < 30)
                return "Acima do peso";
            if (indiceImc >= 30 && indiceImc < 35)
                return "Obesidade I";
            if (indiceImc >= 35 && indiceImc < 40)
                return "Obesidade II (severa)";
            if (indiceImc > 40)
                return "Obesidade III (mórbida)";

            return string.Empty;
        }
    }
}