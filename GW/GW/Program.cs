using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GW.Projeto;

namespace GW
{
    class Program
    {

        static void Main(string[] args)
        {
            //Definindo a data
            Console.WriteLine("Digite o ano para agendar");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mês para agendar");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o dia para agendar");
            int day = Convert.ToInt32(Console.ReadLine());

            //Definindo a quantidade de cachorro
            Console.WriteLine("Digite a quantidade de cães pequenos");           
            int quant_cao_pequeno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de cães grandes");            
            int quant_cao_grande = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            ChowChawgas chow = new ChowChawgas(quant_cao_pequeno, quant_cao_grande);
            chow.Preco();

            Meu__Canino_Feliz meu__Canino_Feliz = new Meu__Canino_Feliz(quant_cao_pequeno, quant_cao_grande);
            meu__Canino_Feliz.Preco();

            Vai__Rex vai__Rex = new Vai__Rex(quant_cao_pequeno, quant_cao_grande);
            vai__Rex.Preco();

            Console.Clear();

            DateTime date = new DateTime(year, month, day);            

            //Verificando qual dia da semana para usar os valores equivalentes
            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                chow.Preco();
                meu__Canino_Feliz.Preco_fim_de_semana();
                vai__Rex.Preco_fim_de_semana();
            }

            else
            {
                chow.Preco();
                meu__Canino_Feliz.Preco();
                vai__Rex.Preco();
            }

          //Verificando o melhor preço
            if (chow.Valor_total < meu__Canino_Feliz.Valor_total && chow.Valor_total <  vai__Rex.Valor_total) //Verificando se ChowChawgas é a melhor opção
            {
                Console.WriteLine("Melhor opção: ChowChawgas \nValor total: " + chow.Valor_total);
            }
            
           else if(meu__Canino_Feliz.Valor_total < chow.Valor_total && meu__Canino_Feliz.Valor_total < vai__Rex.Valor_total) //Verificando se Meu canino feliz é a melhor opção
            {
                Console.WriteLine("Melhor opção: Meu canino feliz \nValor total: " + meu__Canino_Feliz.Valor_total);
            }

            
            else if(vai__Rex.Valor_total < chow.Valor_total && vai__Rex.Valor_total < meu__Canino_Feliz.Valor_total)
            {
                Console.WriteLine("Melhor opção: Vai Rex  \nValor total: " + vai__Rex.Valor_total);
            }

            //Decidindo melhor opção caso os preços sejam os mesmo 
            else if (chow.Valor_total == meu__Canino_Feliz.Valor_total )
            {
                if(chow.Distancia < meu__Canino_Feliz.Distancia)
                {
                    Console.WriteLine("Melhor opção: ChowChawgas \nValor total: " + chow.Valor_total);
                }

                else
                {
                    Console.WriteLine("Melhor opção: Meu canino feliz \nValor total: " + meu__Canino_Feliz.Valor_total);
                }
            }

            else if (chow.Valor_total == vai__Rex.Valor_total)
            {
                if (chow.Distancia < vai__Rex.Distancia)
                {
                    Console.WriteLine("Melhor opção: ChowChawgas \nValor total: " + chow.Valor_total);
                }

                else
                {
                    Console.WriteLine("Melhor opção: Vai Rex  \nValor total: " + vai__Rex.Valor_total);
                }
            }

            else if (meu__Canino_Feliz.Valor_total == vai__Rex.Valor_total)
            {
                if (meu__Canino_Feliz.Distancia < vai__Rex.Distancia)
                {
                    Console.WriteLine("Melhor opção: Meu canino feliz \nValor total: " + meu__Canino_Feliz.Valor_total);
                }

                else
                {
                    Console.WriteLine("Melhor opção: Vai Rex  \nValor total: " + vai__Rex.Valor_total); 
                }
            }

        }


        }
    }

