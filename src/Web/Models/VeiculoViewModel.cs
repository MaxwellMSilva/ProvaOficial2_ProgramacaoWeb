using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Web.Models
{
    public class VeiculoViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Veiculo_Marca { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Veiculo_Modelo { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Veiculo_Ano { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Veiculo_Quilometragem { get; set; }
    }
}
