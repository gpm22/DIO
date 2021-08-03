using System;

namespace games_catalog.Exceptions
{
    public class GameAlreadyRegisteredExeption: Exception
    {
        public GameAlreadyRegisteredExeption() : base("Este jogo já está cadastrado")
        {}
    }
}