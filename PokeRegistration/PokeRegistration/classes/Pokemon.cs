using System;

namespace PokeRegistration
{
    public class Pokemon : EntidadeBase
    {
        private string Nome {get; set;}

        private TipoPokemon Tipo {get; set;}

        private RegiaoPokemon Regiao {get; set;}

        private string Descricao {get; set;}

        private bool Excluido {get; set;}


        public Pokemon(int id, string nome, TipoPokemon tipoPokemon, RegiaoPokemon regiaoPokemon, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipoPokemon;
            this.Regiao = regiaoPokemon;
            this.Descricao = descricao;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno ="";

            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Tipo: " + this.Tipo + Environment.NewLine;
            retorno += "Regiao: " + this.Regiao + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            
            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir(){
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

    }
}