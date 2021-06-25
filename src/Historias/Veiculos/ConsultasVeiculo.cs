using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Historias.Veiculos
{
    public class ConsultasVeiculo
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public ConsultasVeiculo(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<Veiculo> BuscarPorId(int id)
        {
            return await _veiculoRepository.BuscarPorId(id);
        }


        public async Task<IEnumerable<Veiculo>> TodosVeiculos()
        {
            return await _veiculoRepository.TodosVeiculos();
        }

        public async Task<IEnumerable<Veiculo>> VeiculosMarca(string marca)
        {
            return await _veiculoRepository.VeiculosMarca(marca);
        }

        public async Task<IEnumerable<Veiculo>> VeiculosModelo(string modelo)
        {
            return await _veiculoRepository.VeiculosModelo(modelo);
        }
    }
}
