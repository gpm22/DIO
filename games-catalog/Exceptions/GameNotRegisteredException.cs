using System;

namespace games_catalog.Exceptions
{
    public class GameNotRegisteredException : Exception
    {
        public GameNotRegisteredException() : base("Este jogo não está cadastrado")
        {}
    }
}