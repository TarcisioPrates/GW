using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GW.Projeto
{
    class ChowChawgas : Petshop
    {
      
       
        public ChowChawgas()
        {
            
        }
        public ChowChawgas(int quant_cao_pequeno, int quant_cao_grande) : base(quant_cao_pequeno, quant_cao_grande)
        {
            Distancia = 0.8;
        }

        
        public override void Preco() 
        {

            Valor_cao_grande = 45.0;
            Valor_cao_pequeno = 30.0;
            base.Preco();

        }

        
    }
}
