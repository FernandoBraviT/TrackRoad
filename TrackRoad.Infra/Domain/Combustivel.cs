using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrackRoad.Infra.Domain
{
    public class Combustivel
    {
        [Key]
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome Obrigatório")]
        public string Nome { get; set; }

        [DisplayName("Preco")]
        public double Preco { get; set; }
    }
}
