using System;
using System.Collections.Generic;

namespace PokeBank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1": ListarContas(); break;
                    case "2": InserirConta(); break;
                    case "3": Transferir(); break;
                    case "4": Sacar(); break;
                    case "5": Depositar(); break;
                    case "C": Console.Clear(); break;

                    default: throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos PokeServiços!\nPika pi!");
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da PokeConta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            if(listContas.Count - 1 < indiceConta)
            {
                Console.WriteLine("Não existe essa PokeConta.");
                return;
            }
            
            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da PokeConta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            if(listContas.Count - 1 < indiceConta)
            {
                Console.WriteLine("Não existe essa PokeConta.");
                return;
            }
            
            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorParaSacar = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorParaSacar);
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da PokeConta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            if(listContas.Count - 1 < indiceContaOrigem)
            {
                Console.WriteLine("Não existe essa PokeConta.");
                return;
            }

            Console.WriteLine("Digite o número da PokeConta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            if(listContas.Count - 1 < indiceContaDestino)
            {
                Console.WriteLine("Não existe essa PokeConta.");
                return;
            }
            
            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar PokeContas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Não existem PokeContas cadastradas.");
                return;
            }

            for (int i=0; i<listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0}", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova PokeConta");

            Console.WriteLine("Digite 1 para PokeConta Física ou 2 para PokeConta Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Treinador");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cŕedito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            listContas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Pikachu\'s Bank, um banco para treinadores pokémon.");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar PokeContas");
            Console.WriteLine("2 - Inserir nova PokeConta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
