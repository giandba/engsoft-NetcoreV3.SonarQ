namespace NetcoreV3.SonarQ.Apps.Interfaces
{
    public interface IGerarCodigoCadastro
    {
        public string TipoCodigo { get; }
        string Gerar();
    }
}