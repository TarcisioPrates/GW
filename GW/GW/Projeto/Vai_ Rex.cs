using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW.Projeto
{
    class Vai__Rex : Petshop
    {
        public Vai__Rex()
        {
            
        }

        public Vai__Rex(int quant_cao_pequeno, int quant_cao_grande) : base(quant_cao_pequeno, quant_cao_grande)
        {
            Distancia = 1.7;
        }

        public override void Preco()
        {
            
            Valor_cao_pequeno = 15;
            Valor_cao_grande = 50;
           
            base.Preco();
        }

        public override void Preco_fim_de_semana()
        {
           
            Valor_cao_pequeno = 20;
            Valor_cao_grande = 55;            
            base.Preco_fim_de_semana();
        }
    }
}
