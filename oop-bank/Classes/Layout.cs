using System;
using System.Collections.Generic;
using System.Text;

namespace oop_bank.Classes
{
    public class Layout
    {

        private static int opcao = 0;


        public static void TelaPrincipal() 
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("                                          ");
            Console.WriteLine("         Digite a opção desejada:         ");
            Console.WriteLine("         ===========================      ");
            Console.WriteLine("         1 - Criar Conta                  ");
            Console.WriteLine("         ===========================      ");
            Console.WriteLine("         2 - Entrar com CPF e Senha       ");
            Console.WriteLine("         ===========================      ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }



        }


        private static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("                                          ");
            Console.WriteLine("         Digite seu nome:                 ");
            string nome = Console.ReadLine();
            Console.WriteLine("         ===========================      ");
            Console.WriteLine("         Digite o CPF:                    ");
            string cpf = Console.ReadLine();
            Console.WriteLine("         ===========================      ");
            Console.WriteLine("         Digite sua senha:                ");
            string senha = Console.ReadLine();
            Console.WriteLine("         ===========================      ");

            Console.WriteLine(nome);
            Console.WriteLine(cpf);
            Console.WriteLine(senha);


        }

        private static void TelaLogin()
        {
            Console.Clear();
            Console.WriteLine("                                          ");
            Console.WriteLine("         Digite o CPF:                    ");
            string cpf = Console.ReadLine();
            Console.WriteLine("         ===========================      ");
            Console.WriteLine("         Digite sua senha:                ");
            string senha = Console.ReadLine();
            Console.WriteLine("         ===========================      ");
           

        }
    }
}
