using System;
using System.ComponentModel.DataAnnotations;

namespace games_catalog.Models.InputModel
{
    public class GameInputModel
    {
        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage ="O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Name {get; set;}

        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage ="O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Producer {get; set;}

        [Required]
        [Range(1, 1000, ErrorMessage ="O preço do jogo deve conter entre 1-1000 reais")]
        public double Price {get; set;}
    }
}