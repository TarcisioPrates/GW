using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GW.Projeto
{
    class Petshop
    {
        public double Valor_cao_pequeno { get; set; }
        public double Valor_cao_grande { get; set; }
        public int Quant_cao_pequeno { get; set; }
        public int Quant_cao_grande { get; set; }
        public double Distancia { get; set; }
        public double Valor_total { get; set; }

        public  Petshop( )
        {
           // Quant_cao_pequeno = quant_cao_pequeno;
           // Quant_cao_grande = quant_cao_grande;
            
        }

        public Petshop(int quant_cao_pequeno, int quant_cao_grande)
        {
            Quant_cao_pequeno = quant_cao_pequeno;
            Quant_cao_grande = quant_cao_grande;
        }

        public virtual void Preco ()
        {
            Valor_total = (Valor_cao_grande * Quant_cao_grande) + (Valor_cao_pequeno * Quant_cao_pequeno);
        }

        public virtual void Preco_fim_de_semana()
        {
            Valor_total = (Valor_cao_grande * Quant_cao_grande) + (Valor_cao_pequeno * Quant_cao_pequeno);
        }
    }
}
