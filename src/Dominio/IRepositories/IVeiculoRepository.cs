using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.IRepositories
{
    public interface IVeiculoRepository
    {
        Task CriarVeiculo(Veiculo veiculo);
        Task AlterarVeiculo(Veiculo veiculo);
        Task ExcluirVeiculo(Veiculo veiculo);

        Task<Veiculo> BuscarPorId(int id);
        Task<IEnumerable<Veiculo>> TodosVeiculos();
        Task<IEnumerable<Veiculo>> VeiculosMarca(string marca);
        Task<IEnumerable<Veiculo>> VeiculosModelo(string modelo);
    }
}
