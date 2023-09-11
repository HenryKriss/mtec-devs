using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtecDevs.Models;

[Table("Usuario")]
    public class Usuario
    {

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLenght(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        public DateTime DataNascimento {get; set;}

        [StringLenght(300)]
        public string Foto {get; set;}

        [Display(nameof = "Tipo de Desenvolvidor")]
        [Required(ErrorMessage = "Informe o Tipo de Desenvolvidor")]
        public byte TipoDevId {get; set;}

        [ForeignKey("TipoDevId")]
        public TipoDev TipoDev {get; set; }
    }