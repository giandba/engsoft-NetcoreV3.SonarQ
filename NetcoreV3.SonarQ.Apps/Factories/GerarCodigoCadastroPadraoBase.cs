namespace NetcoreV3.SonarQ.Apps.Factories
{
    public abstract class GerarCodigoCadastroPadraoBase
    {
        public GerarCodigoCadastroPadraoBase()
        {
        }

        public string GeraCodigo(int codigo, string prefixo, string sufixo){
            return $"{prefixo}-{codigo}-{sufixo}";
        }
    }
}