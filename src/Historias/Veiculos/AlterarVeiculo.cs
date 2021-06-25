using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historias.Veiculos
{
    public class AlterarVeiculo
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public AlterarVeiculo(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task Executar(int id, Veiculo veiculo)
        {
            var dadosDoVeiculo = await _veiculoRepository.BuscarPorId(id);

            dadosDoVeiculo.AtualizarVeiculo(veiculo.Veiculo_Marca, veiculo.Veiculo_Modelo, veiculo.Veiculo_Ano, veiculo.Veiculo_Quilometragem);

            await _veiculoRepository.AlterarVeiculo(dadosDoVeiculo);
        }
    }
}
