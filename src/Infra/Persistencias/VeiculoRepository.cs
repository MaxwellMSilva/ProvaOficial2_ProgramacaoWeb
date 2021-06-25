using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistencias
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly DataContext _dataContext;
        public VeiculoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CriarVeiculo(Veiculo veiculo)
        {
            _dataContext.Veiculos.Add(veiculo);
            await _dataContext.SaveChangesAsync();
        }

        public async Task AlterarVeiculo(Veiculo veiculo)
        {
            _dataContext.Update(veiculo);
            await _dataContext.SaveChangesAsync();
        }

        public async Task ExcluirVeiculo(Veiculo veiculo)
        {
            _dataContext.Remove(veiculo);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Veiculo> BuscarPorId(int id)
        {
            return await _dataContext.Veiculos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Veiculo>> TodosVeiculos()
        {
            return await _dataContext.Veiculos.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Veiculo>> VeiculosMarca(string marca)
        {
            return await _dataContext.Veiculos.AsNoTracking().Where(x => x.Veiculo_Marca == marca).ToListAsync();
        }

        public async Task<IEnumerable<Veiculo>> VeiculosModelo(string modelo)
        {
            return await _dataContext.Veiculos.AsNoTracking().Where(x => x.Veiculo_Modelo == modelo).ToListAsync();
        }
    }
}
