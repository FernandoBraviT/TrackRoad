using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrackRoad.Infra.Domain
{
    public class Contrato
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Emp")]
        [Required(ErrorMessage = "Empresa Obrigatório")]
        [MaxLength(20, ErrorMessage = "Empresa deve conter 20 caracteres")]
        public string Empresa { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "Valor Obrigatório")]
        public double Valor { get; set; }

        [DisplayName("Doc")]
        [Required(ErrorMessage = "Doc Obrigatório")]
        public string Doc { get; set; }

        [DisplayName("Cliente")]
        [Required(ErrorMessage = "Cliente é Obrigatório")]
        public virtual Cliente Cliente { get; set; }
    }
}
