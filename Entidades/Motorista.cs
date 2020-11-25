﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Motorista
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [MaxLength(50, ErrorMessage = "Nome deve conter 50 caracteres")]
        public string Nome { get; set; }

        [DisplayName("Cnh")]
        [Required(ErrorMessage = "CNH Obrigatório")]
        [MaxLength(10, ErrorMessage = "CNH deve conter 10 caracteres")]
        public string Cnh { get; set; }

        [DisplayName("TipVeic")]
        public string TipoVeiculo { get; set; }

        [DisplayName("ModVeic")]
        [Required(ErrorMessage = "Bairro de Destino Obrigatório")]
        [MaxLength(25, ErrorMessage = "Modelo do Veiculo deve conter 25 caracteres")]
        public string ModeloVeiculo { get; set; }

        [DisplayName("MarcVeic")]
        [Required(ErrorMessage = "Marca do Veiculo Obrigatório")]
        [MaxLength(50, ErrorMessage = "Marca do Veiculo deve conter 50 caracteres")]
        public string MarcaVeiculo { get; set; }

        [DisplayName("AnoFab")]
        public int AnoFabricacao { get; set; }

        [DisplayName("KmLitro")]
        [Required(ErrorMessage = "CEP de Destino Obrigatório")]
        [MaxLength(10, ErrorMessage = "CEP de Destino deve conter 10 caracteres")]
        public string KmLitro { get; set; }

        [ForeignKey("Combustivel")]
        public int IdCombustivel { get; set; }
        public virtual Combustivel Combustivel { get; set; }
    }
}
