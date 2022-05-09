using System;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps.Factories
{
    public class GerarCodigoCadastroPadrao1 : GerarCodigoCadastroPadraoBase, IGerarCodigoCadastro
    {
        public string TipoCodigo => "PADRAO1";

        /// <summary>
        ///    Padrão 1: "ABC-000000";
        /// </summary>
        public string Gerar()
        {
            var codigoRandon = new Random().Next(100000, 999999);
            return base.GeraCodigo(codigoRandon, "ABC", "");
        }
    }
}