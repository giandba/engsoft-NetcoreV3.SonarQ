namespace NetcoreV3.SonarQ.Apps.Factories
{
    public abstract class GerarCodigoCadastroPadraoBase
    {
        public GerarCodigoCadastroPadraoBase()
        {
        }

        public string GeraCodigo(int codigo, string prefixo, string sufixo)
        {
            var result = new System.Text.StringBuilder(100);

            if (!string.IsNullOrEmpty(prefixo))
            {
                result.Append(prefixo);
                result.Append("-");
            }

            result.Append(codigo.ToString());
            
            if (!string.IsNullOrEmpty(sufixo))
            {
                result.Append("-");
                result.Append(sufixo);
            }

            return result.ToString();
        }
    }
}