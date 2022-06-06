using System;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps.Factories
{
    public class GerarCodigoCadastroPadrao2 : GerarCodigoCadastroPadraoBase, IGerarCodigoCadastro
    {
        public string TipoCodigo => "PADRAO2";
        /// <summary>
        ///    Padrão 2: "XYZ-000000-CAD";
        /// </summary>
        public string Gerar()
        {
            var codigoRandon = new Random().Next(100000, 999999);
            var prefixoArr = new string[] { "X", "Y", "Z" };

            string prefixo = "";
            for (int i = 0; i < prefixoArr.Length; ++i)
            {
                prefixo = prefixo + prefixo[i];
            }

            return base.GeraCodigo(codigoRandon, prefixo, "CAD");
        }
    }
}