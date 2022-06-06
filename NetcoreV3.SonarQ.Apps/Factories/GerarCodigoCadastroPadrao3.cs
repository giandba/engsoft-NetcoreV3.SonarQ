using System;
using System.Linq;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Apps.Factories
{
    public class GerarCodigoCadastroPadrao3 : GerarCodigoCadastroPadraoBase, IGerarCodigoCadastro
    {
        public string TipoCodigo => "PADRAO3";
        /// <summary>
        ///    Padrão 3: "PROD-000000-[X]-000000-[X]-[DIFF]-[PAR | IMPAR]";
        //     [X] = SE CODIGO FOR PAR, ULTIMO DIGITO SENAO O PRIMEIRO
        //     [DIFF] = (CODIGO1 + CODIGO2) / 2
        /// </summary>
        public string Gerar()
        {
            var codigoRandon1 = new Random().Next(100000, 999999);
            var codigoRandon2 = new Random().Next(100000, 999999);
            var p1 = "PROD";
            var s1 = "TEST";
            var c1 = "";
            var c2 = "";
            var codigoRandon1Array = codigoRandon1.ToString().ToArray();
            var diffParImpart = "";

            if(codigoRandon1 > 0){
                for (int i = 0; i < codigoRandon1.ToString().Length; i++)
                {
                    if(codigoRandon1 % 2 == 0 && codigoRandon1.ToString()[i].ToString().Length >= 0){
                        c1 = codigoRandon1.ToString()[i].ToString();
                    }else if(codigoRandon1.ToString()[i].ToString().Length >= 0){
                        c1 = codigoRandon1.ToString()[0].ToString();
                    }else{
                        c1="X";
                    }
                }
            }
            
            if(codigoRandon1 > 0){
                for (int i = 0; i < codigoRandon2.ToString().Length; i++)
                {
                    if(codigoRandon2 % 2 == 0 && codigoRandon1.ToString()[i].ToString().Length >= 0){
                        c2 = codigoRandon1.ToString()[i].ToString();//
                    }else if(codigoRandon1.ToString()[i].ToString().Length >= 0){
                        c2 = codigoRandon2.ToString()[0].ToString();
                    }else{
                        c2="X";
                    }
                }
            }

            var diff = (codigoRandon1 + codigoRandon2) / 2;

            if(diff % 2 == 0){
                diffParImpart = "PAR";
            }else if(diff % 2 != 0){
                diffParImpart = "IMPAR";
            }

            return $"PROD-{codigoRandon1}-{c1}-{codigoRandon2}-{c2}-{diff}-{diffParImpart}";
        }
    }
}