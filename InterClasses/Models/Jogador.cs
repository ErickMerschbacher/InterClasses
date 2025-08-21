using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Jogador
    {
        [Required(ErrorMessage = "O campo Id do Jogador é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O Id do Jogador deve ser um número positivo")]
        [MaxLength(10, ErrorMessage = "O Id do Jogador pode ter no máximo 10 caracteres")]
        public int JogadorId { get; set; }
        [Required(ErrorMessage = "O campo Nome do Jogador é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do Jogador pode ter no máximo, 50 caracteres")]
        public string? Nome { get; set; }
        [MaxLength(20, ErrorMessage = "A posição do Jogador pode ter no máximo, 20 caracteres")]
        [Display(Name = "Posição")]
        public string? Posicao { get; set; }
        [Required(ErrorMessage = "O campo Número do Jogador é Obrigatório")]
        [Range(1, 99, ErrorMessage = "O número do Jogador deve estar entre 1 e 99")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        //Relacionamento Jogador X Time
        [Display(Name = "Time")]
        public int TimeId { get; set; }
        public Time? Time { get; set; }

    }

}
