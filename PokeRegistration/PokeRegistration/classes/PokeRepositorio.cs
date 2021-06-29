using System.Collections.Generic;
using System;

namespace PokeRegistration
{
    public class PokeRepositorio : Repositorio<Pokemon>
    {
        private List<Pokemon> listaDePokemons = new List<Pokemon>();
        public void Atualiza(int id, Pokemon entidade)
        {
            listaDePokemons[id] = entidade;
            Console.WriteLine("Pokemon " + entidade.retornaNome()+ " atualizado! ");
        }

        public void Exclui(int id)
        {
            listaDePokemons[id].Excluir();
            Console.WriteLine("Pokemon " + listaDePokemons[id].retornaNome()+ " Excluido! ");
        }

        public void Insere(Pokemon entidade)
        {
            listaDePokemons.Add(entidade);
            Console.WriteLine("Pokemon " + entidade.retornaNome() + " Adicionado! ");
        }

        public List<Pokemon> Lista()
        {
            return listaDePokemons;
        }

        public int ProximoId()
        {
            return listaDePokemons.Count;
        }

        public Pokemon RetornaPorId(int id)
        {
            return listaDePokemons[id]; 
        }
    }
}