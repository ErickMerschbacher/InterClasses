using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }

        //Torna o campo nome obrigatório
        [Required(ErrorMessage = "O Nome do Esporte é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do Esporte pode ter no máximo, 50 caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade máxima de Jogadores por Time")]

        [Range(1, 25, ErrorMessage = "O número de jogadores deve estar entre 1 e 25")] //Limita a quantidade

        [Display(Name = "Quantidade de Jogadores")]
        public int QtJogadores { get; set; }
    }
}
