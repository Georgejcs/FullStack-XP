using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_Basica.Common.Models
{
    public class Repeticao
    {
        public void Enquanto(int numero)
        {
            int i = 0;
            while (i <= numero)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                i++;

                if(i == 25)
                    break;
            }
        }

        public void FacaEnquanto()
        {
            int soma = 0, numero = 0;
            do
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;


            } while(numero != 0);

            Console.Write($"Total: {soma}");
        }

        public void Durante(int numero){
        
            for(int i = 0; i <= numero; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

        }

        // public void Menu()
        // {
        //     string opcao;
        //     bool exibirMenu = true;
        //     while(exibirMenu)
        //     {
        //         Console.WriteLine("1 - Cadastrar clinete");
        //         Console.WriteLine("2 - Buscar cliente");
        //         Console.WriteLine("3 - Apagar cliente:");
        //         Console.WriteLine("4 - Encerrar");

        //         opcao = Console.ReadLine();

        //         switch(opcao)
        //         {
        //             case "1":
        //                 Console.WriteLine("Cadastro de cliente");
        //             break;
        //             case "2":
        //                 Console.WriteLine("Busca de cliente");
        //             break;
        //             case "3":
        //                 Console.WriteLine("Apagar cliente");
        //             break;
        //             case "4":
        //                 Console.WriteLine("Encerrar");
        //                 exibirMenu = false;
        //                 //Environment.Exit(0);
        //             break;
        //             default:
        //                 Console.WriteLine("Opção inválida");
        //                 break;
        //         }
        //     }

        //     Console.WriteLine("O programa se encerrou");
        // }
    }
}