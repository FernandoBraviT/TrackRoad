using Entidades;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrackRoad.Application.ViewModels
{
    public class CombustivelViewModel
    {
        public CombustivelViewModel(Combustivel combustivel)
        {
            if (combustivel.Id != 0)
                this.Id = combustivel.Id;

            this.Nome = combustivel.Nome;
            this.Preco = combustivel.Preco;
        }

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
