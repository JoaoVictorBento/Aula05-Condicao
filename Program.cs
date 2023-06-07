using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05___Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variáveis
            
            int idade;

            //Boas vindas
            
            Console.Write(" -- Bem-vindo ao DETRAN -- ");

            //Espaço

            Console.Write("\n\n");

            //idade
            
            Console.Write("Digite sua idade:");

            idade = int.Parse( Console.ReadLine() );

            //Espaço

            Console.Write("\n");
            
            //Verificação

            if ( idade >= 18) 
            {

                //daclaração de variáveis

                string posse_cnh;

                //confirmação

                Console.WriteLine("Você já pode tirar a CNH!");

                //Espaço
                
                Console.Write("\n\n");

                //Posse de CNH
                
                Console.Write(" -- Você já tem uma carteira CNH ? Digite sim ou não:");
                posse_cnh = Console.ReadLine();

                //Nova/Renovação
                
                if( posse_cnh == "sim")
                {

                    //Espaço

                    Console.Write("\n\n");

                    //Fim
                    
                    Console.WriteLine("Então você tem que RENOVAR sua CNH!");


                }

                else
                {

                    //Espaço

                    Console.Write("\n\n");

                    //Fim
                    
                    Console.WriteLine("Você está tirando sua primeira carteira.");

                }
            
            }

            else
            {

                //Espaço
                
                Console.Write("\n");
                
                //Negação
                
                Console.WriteLine("Você ainda não tem idade!");

            }
            
            Console.ReadKey();
            
            Main(null);
        
        }
    }
}
