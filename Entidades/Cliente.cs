using Entidades.ViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(ClienteViewModel cliente)
        {
            Id = cliente.Id;
            Bairro = cliente.Bairro;
            Cep = cliente.Cep;
            Cidade = cliente.Cidade;
            Cnpj = cliente.Cnpj;
            Endereco = cliente.Endereco;
            Estado = cliente.Estado;
            NomeFantasia = cliente.NomeFantasia;
            Numero = cliente.Numero;
            RamoAtividade = cliente.RamoAtividade;
            RazaoSocial = cliente.RazaoSocial;
        }

        [Key]
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Cep")]
        public string Cep { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Cidade Obrigatório")]
        [MaxLength(30, ErrorMessage = "Cidade não deve conter mais que 30 caracteres")]
        public string Cidade { get; set; }

        [DisplayName("Cnpj")]
        [Required(ErrorMessage = "Cnpj Obrigatório")]
        [MinLength(14, ErrorMessage = "Cnpj deve conter 14 números")]
        [MaxLength(14, ErrorMessage = "Cnpj deve conter 14 números")]
        public string Cnpj { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Endereço Obrigatório")]
        [MaxLength(50, ErrorMessage = "Endereço não deve conter mais que 50 caracteres")]
        public string Endereco { get; set; }
        public string Estado { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome Obrigatório")]
        [MinLength(3, ErrorMessage = "Nome deve conter entre 3 e 50 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve conter entre 3 e 50 caracteres")]
        public string NomeFantasia { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "Número Obrigatório")]
        public int Numero { get; set; }

        [DisplayName("Ramo Atividade")]
        [Required(ErrorMessage = "Ramo de Atividade Obrigatório")]
        [MaxLength(20, ErrorMessage = "Ramo de Atividade não deve conter mais que 50 caracteres")]
        public string RamoAtividade { get; set; }

        [DisplayName("Razão Social")]
        [Required(ErrorMessage = "Razão Social Obrigatório")]
        [MaxLength(50, ErrorMessage = "Razão Social não deve conter mais que 50 caracteres")]
        public string RazaoSocial { get; set; }
    }
}
