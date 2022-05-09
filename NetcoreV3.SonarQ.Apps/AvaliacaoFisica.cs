using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps
{
    public class AvaliacaoFisica : IAvaliacaoFisica
    {
        public decimal CalcularIMC(decimal alturaCM, decimal pesoKG)
        {
            var teste = 0;
            return 90;
        }

        protected void MetodoNaoChamado(){
            
        }
    }
}