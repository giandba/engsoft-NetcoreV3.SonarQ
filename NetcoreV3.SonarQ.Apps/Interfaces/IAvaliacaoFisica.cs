namespace NetcoreV3.SonarQ.Apps.Interfaces
{
    public interface IAvaliacaoFisica
    {
        
        /// <summary>
        ///    IMC = peso / (altura x altura).
        /// </summary>
         double CalcularIMC(double alturaCm, double pesoKg);

         string RetornaClassificacaoIMC(double indiceImc);
    }
}