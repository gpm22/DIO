using System;

namespace PokeRegistration
{
    class Program
    {
        static PokeRepositorio repositorio = new PokeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1": ListarPokeRegistros(); break;
                    case "2": InserirPokeRegistro(); break;
                    case "3": AtualizarPokeRegistro(); break;
                    case "4": ExcluirSerie(); break;
                    case "5": VisualizarPokeSerie(); break;
                    case "C": Console.Clear(); break;

                    default: throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Volte sempre!\nTemos que pegar!");
        }

        private static void VisualizarPokeSerie()
        {
            Console.WriteLine("Visualizar PokeRegistro");

            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var lista = repositorio.Lista();

            if (lista.Count - 1 < id)
            {
                Console.WriteLine("PokeRegistro Não Cadastrado");
                return;
            }

            var pokemon = repositorio.RetornaPorId(id);

            Console.WriteLine(pokemon);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Excluir PokeRegistro");

            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var lista = repositorio.Lista();

            if (lista.Count - 1 < id)
            {
                Console.WriteLine("PokeRegistro Não Cadastrado");
                return;
            }

            repositorio.Exclui(id);
        }

        private static void AtualizarPokeRegistro()
        {
            Console.WriteLine("Atualizar PokeRegistro");

            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var lista = repositorio.Lista();

            if (lista.Count -1 < id)
            {
                Console.WriteLine("PokeRegistro Não Cadastrado");
                return;
            }

            Console.WriteLine("Digite o nome do Pokémon: ");
            string entradaNome = Console.ReadLine();
            Console.WriteLine("Opções de Tipos:");
            foreach (int i in Enum.GetValues(typeof(TipoPokemon)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(TipoPokemon), i));
            }

            Console.WriteLine("Digite o tipo do Pokémon entre as opções acima: ");
            int entradaTipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Opções de Regiões:");
            foreach (int i in Enum.GetValues(typeof(RegiaoPokemon)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(RegiaoPokemon), i));
            }

            Console.WriteLine("Digite a região do Pokémon entre as opções acima: ");
            int entradaRegiao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição sobre o Pokémon: ");
            string entradaDescricao = Console.ReadLine();

            Pokemon novoPokemon = new Pokemon(  id,
                                                entradaNome,
                                                (TipoPokemon)entradaTipo,
                                                (RegiaoPokemon)entradaRegiao,
                                                entradaDescricao);

            repositorio.Atualiza(id, novoPokemon);


        }

        private static void InserirPokeRegistro()
        {
            Console.WriteLine("Inserir novo PokeRegistro");

            Console.WriteLine("Digite o nome do Pokémon: ");
            string entradaNome = Console.ReadLine();
            Console.WriteLine("Opções de Tipos:");
            foreach (int i in Enum.GetValues(typeof(TipoPokemon)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(TipoPokemon), i));
            }

            Console.WriteLine("Digite o tipo do Pokémon entre as opções acima: ");
            int entradaTipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Opções de Regiões:");
            foreach (int i in Enum.GetValues(typeof(RegiaoPokemon)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(RegiaoPokemon), i));
            }

            Console.WriteLine("Digite a região do Pokémon entre as opções acima: ");
            int entradaRegiao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição sobre o Pokémon: ");
            string entradaDescricao = Console.ReadLine();

            Pokemon novoPokemon = new Pokemon(  repositorio.ProximoId(),
                                                entradaNome,
                                                (TipoPokemon)entradaTipo,
                                                (RegiaoPokemon)entradaRegiao,
                                                entradaDescricao);

            repositorio.Insere(novoPokemon);
        }

        private static void ListarPokeRegistros()
        {
            Console.WriteLine("Listar PokeRegistros");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum PokeRegistro Cadastrado");
                return;
            }

            foreach (var pokeRegistro in lista)
            {
                if(!pokeRegistro.retornaExcluido()){
                    Console.WriteLine("#ID {0}: - {1}", pokeRegistro.retornaId(), pokeRegistro.retornaNome());
                }
                
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("PokeRegistration, não acredito que não é uma PokeDex!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Pokémons Registrados");
            Console.WriteLine("2 - Inserir novo PokeRegistro");
            Console.WriteLine("3 - Atualizar PokeRegistro");
            Console.WriteLine("4 - Excluir PokeRegistro");
            Console.WriteLine("5 - Visualizar PokeRegristro");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
