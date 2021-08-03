using System;

namespace games_catalog.Models.ViewModel
{
    public class GameViewModel
    {
        public Guid Id {get; set;}

        public string Name {get; set;}

        public string Producer {get; set;}

        public double Price {get; set;}
        
    }
}