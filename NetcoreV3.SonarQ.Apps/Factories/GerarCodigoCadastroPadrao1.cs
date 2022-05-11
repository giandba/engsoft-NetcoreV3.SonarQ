using System;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps.Factories
{
    public class GerarCodigoCadastroPadrao1 : GerarCodigoCadastroPadraoBase, IGerarCodigoCadastro
    {
        private readonly IGerarCodigoRandomico _gerarCodigoRandomico;

        public GerarCodigoCadastroPadrao1(IGerarCodigoRandomico gerarCodigoRandomico)
        {
            this._gerarCodigoRandomico = gerarCodigoRandomico;
        }

        public string TipoCodigo => "PADRAO1";

        /// <summary>
        ///    Padrão 1: "ABC-000000";
        /// </summary>
        public string Gerar()
        {
            //var codigoRandon = new Random().Next(100000, 999999);
            var codigoRandon = this._gerarCodigoRandomico.GerarCodigo();
            return base.GeraCodigo(codigoRandon, "ABC", "");
        }
    }
}