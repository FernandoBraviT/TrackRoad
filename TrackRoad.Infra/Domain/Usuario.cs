using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrackRoad.Infra.Domain
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Login")]
        [Required(ErrorMessage = "Login Obrigatório")]
        [MinLength(5, ErrorMessage = "Login deve conter 5 caracteres")]
        [MaxLength(30, ErrorMessage = "Login deve conter 10 caracteres")]
        public string Login { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Senha Obrigatória")]
        [MinLength(5, ErrorMessage = "Senha deve conter 5 caracteres")]
        [MaxLength(10, ErrorMessage = "Senha deve conter 10 caracteres")]
        public string Password { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "E-mail Obrigatório")]
        [MaxLength(30, ErrorMessage = "E-mail deve conter 30 caracteres")]
        public string Email { get; set; }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Tipo de usuário Obrigatório")]
        public int Tipo { get; set; }
    }
}
