using System;
using NetcoreV3.SonarQ.Apps.DomainExceptions;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps
{
    public class AvaliacaoFisica : IAvaliacaoFisica
    {
        /// <summary>
        ///    IMC = peso / (altura x altura).
        /// </summary>
        public double CalcularIMC(double alturaCm, double pesoKg)
        {
            try
            {

                double alturaM = alturaCm / 100;
                double imc = pesoKg / (alturaM * alturaM);
                double imc2Dig = System.Math.Round(imc, 2);
                return imc2Dig;

            }
            catch (Exception ex)
            {
                throw new ValorInvalidoException("Erro ao calcular imc", ex);
            }

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