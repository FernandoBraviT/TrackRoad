using Entidades;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackRoad.Application.ViewModels
{
    public class ContratoViewModel
    {
        public ContratoViewModel(Contrato contrato)
        {
            this.Id = contrato.Id;
            this.Empresa = contrato.Empresa;
            this.Valor = contrato.Valor;
            this.Doc = contrato.Doc;
            this.Cliente = contrato.Cliente;
            this.IdCliente = contrato.IdCliente;
        }

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

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
