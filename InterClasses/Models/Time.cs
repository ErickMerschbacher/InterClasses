using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Time
    {
        public int TimeId { get; set; } //Chave primária (Id)
        [Required(ErrorMessage = "O campo Nome do Time é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do Time pode ter no máximo, 50 caracteres")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }

        //Relacionamento entre Models (Tabelas no Banco de Dados)
        //Chave Estrangeira
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } //Informar o campo do Id da tabela
        public Esporte? Esporte { get; set; } //Vincular o Objeto relacionado ao Id acima.
    }
}
