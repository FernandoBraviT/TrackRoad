using Entidades;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackRoad.Application.ViewModels
{
    public class ViagemViewModel
    {
        public ViagemViewModel(Viagem viagem)
        {
            this.Id = viagem.Id;
            this.TotalDistancia = viagem.TotalDistancia;
            this.EnderecoDestino = viagem.EnderecoDestino;
            this.NumeroDestino = viagem.NumeroDestino;
            this.BairroDestino = viagem.BairroDestino;
            this.CidadeDestino = viagem.CidadeDestino;
            this.EstadoDestino = viagem.EstadoDestino;
            this.CepDestino = viagem.CepDestino;
            this.IdMotorista = viagem.IdMotorista;
            this.Motorista = viagem.Motorista;
        }

        [Key]
        public int Id { get; set; }

        [DisplayName("TotDist")]
        public double TotalDistancia { get; set; }

        [DisplayName("EndDest")]
        [Required(ErrorMessage = "Endereço de Destino Obrigatório")]
        [MaxLength(50, ErrorMessage = "Endereço de Destino deve conter 50 caracteres")]
        public string EnderecoDestino { get; set; }

        [DisplayName("NumDest")]
        [Required(ErrorMessage = "Número de Destino Obrigatório")]
        public int NumeroDestino { get; set; }

        [DisplayName("BaiDest")]
        [Required(ErrorMessage = "Bairro de Destino Obrigatório")]
        [MaxLength(25, ErrorMessage = "Bairro de Destino deve conter 25 caracteres")]
        public string BairroDestino { get; set; }

        [DisplayName("CidDest")]
        [Required(ErrorMessage = "Cidade de Destino Obrigatório")]
        [MaxLength(50, ErrorMessage = "Cidade de Destino deve conter 50 caracteres")]
        public string CidadeDestino { get; set; }

        [DisplayName("EstDest")]
        [Required(ErrorMessage = "Estado de Destino Obrigatório")]
        public string EstadoDestino { get; set; }

        [DisplayName("CepDest")]
        [Required(ErrorMessage = "CEP de Destino Obrigatório")]
        [MaxLength(10, ErrorMessage = "CEP de Destino deve conter 10 caracteres")]
        public string CepDestino { get; set; }

        [ForeignKey("Motorista")]
        public int IdMotorista { get; set; }
        public virtual Motorista Motorista { get; set; }
    }
}
