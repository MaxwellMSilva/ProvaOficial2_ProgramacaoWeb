using System.Collections.Generic;
using Dominio.Entidades;
using Web.Models;

namespace Web.Factory
{
    public static class VeiculoFactory
    {
        public static VeiculoViewModel MapearVeiculoViewModel(Veiculo veiculo)
        {
            var veiculoViewModel = new VeiculoViewModel
            {
                Id = veiculo.Id,
                Veiculo_Marca = veiculo.Veiculo_Marca,
                Veiculo_Modelo = veiculo.Veiculo_Modelo,
                Veiculo_Ano = veiculo.Veiculo_Ano,
                Veiculo_Quilometragem = veiculo.Veiculo_Quilometragem,
            };
            return veiculoViewModel;
        }

        public static Veiculo MapearVeiculo(VeiculoViewModel veiculoViewModel)
        {
            var veiculo = new Veiculo(
                veiculoViewModel.Veiculo_Marca,
                veiculoViewModel.Veiculo_Modelo,
                veiculoViewModel.Veiculo_Ano,
                veiculoViewModel.Veiculo_Quilometragem
            );
            return veiculo;
        }

        public static IEnumerable<VeiculoViewModel> MapearListaVeiculoViewModel(IEnumerable<Veiculo> veiculos)
        {
            var lista = new List<VeiculoViewModel>();
            foreach (var item in veiculos)
            {
                lista.Add(MapearVeiculoViewModel(item));
            }
            return lista;
        }
    }
}
