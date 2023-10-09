using System.ComponentModel.DataAnnotations;
namespace MtecDevs.ViewModels;

    public class LoginVM
    {
        [Display(Name =  "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de usuário")]
        [Required(ErrorMessage =  "Por favor, informe seu email ou nome de usuário")]
        public string Email {get; set; }

        [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha de acesso")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
        [DataType(DataType.Password)]
        public string Senha {get; set; }

        [Display (Name = "Manter conectado?")]
        public bool Lembrar {get; set; } = false;

        public string UrlRetorno {get; set;}



    }
