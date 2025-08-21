using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        [Required(ErrorMessage = "O Nome do Campeonato é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Campeonato deve ter no máximo 50 Caractéres")]
        [Display(Name = "Nome Do Campeonato")]
        public string? Nome { get; set; }

        //Relacionamento Campionato X Esporte
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; }
        public string? Esporte { get; set; }
    }
}
