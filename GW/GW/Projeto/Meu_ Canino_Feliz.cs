using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW.Projeto
{
    class Meu__Canino_Feliz : Petshop
    {


        public Meu__Canino_Feliz()
        {
            
        }

        public Meu__Canino_Feliz(int quant_cao_pequeno, int quant_cao_grande) : base(quant_cao_pequeno, quant_cao_grande)
        {
            Distancia = 2;
        }

        public override void Preco()
        {
            
            Valor_cao_pequeno = 20;
            Valor_cao_grande = 40;
            base.Preco();
        }

        public override void Preco_fim_de_semana()
        {
            
            Valor_cao_pequeno = 20;
            Valor_cao_grande = 40;
            Valor_cao_pequeno += Valor_cao_pequeno * 0.20;
            Valor_cao_grande += Valor_cao_grande * 0.20;
            base.Preco_fim_de_semana();
        }
    }
}
