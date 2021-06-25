using System.Threading.Tasks;
using Dominio.IRepositories;
using Historias.Veiculos;
using Microsoft.AspNetCore.Mvc;
using Web.Factory;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public readonly CriarVeiculo _criarVeiculo;
        public readonly AlterarVeiculo _alterarVeiculo;
        public readonly ExcluirVeiculo _excluirVeiculo;
        public readonly ConsultasVeiculo _consultasVeiculo;

        public HomeController(IVeiculoRepository veiculoRepository)
        {
            _criarVeiculo = new CriarVeiculo(veiculoRepository);
            _alterarVeiculo = new AlterarVeiculo(veiculoRepository);
            _excluirVeiculo = new ExcluirVeiculo(veiculoRepository);
            _consultasVeiculo = new ConsultasVeiculo(veiculoRepository);
        }
        public async Task<IActionResult> Index()
        {
            var listaVeiculos = await _consultasVeiculo.TodosVeiculos();
            var listaVeiculosViewModel = VeiculoFactory.MapearListaVeiculoViewModel(listaVeiculos);

            return View(listaVeiculosViewModel);
        }

        public IActionResult Criar()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(VeiculoViewModel veiculoViewModel)
        {
            if (ModelState.IsValid)
            {
                var veiculo = VeiculoFactory.MapearVeiculo(veiculoViewModel);

                await _criarVeiculo.Executar(veiculo);

                return RedirectToAction("Index");
            }

            return View(veiculoViewModel);
        }

        public async Task<IActionResult> Alterar(int id)
        {
            var veiculo = await _consultasVeiculo.BuscarPorId(id);

            if (veiculo == null)
            {
                return RedirectToAction("Index");
            }

            var veiculoViewModel = VeiculoFactory.MapearVeiculoViewModel(veiculo);

            return View(veiculoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(int id, VeiculoViewModel veiculoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(veiculoViewModel);
            }

            var veiculo = VeiculoFactory.MapearVeiculo(veiculoViewModel);

            await _alterarVeiculo.Executar(id, veiculo);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(int id)
        {
            var veiculo = await _consultasVeiculo.BuscarPorId(id);

            if (veiculo == null)
            {
                return RedirectToAction("Index");
            }

            var veiculoViewModel = VeiculoFactory.MapearVeiculoViewModel(veiculo);

            return View(veiculoViewModel);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var veiculo = await _consultasVeiculo.BuscarPorId(id);

            if (veiculo == null)
            {
                return RedirectToAction("Index");
            }
               

            await _excluirVeiculo.Executar(veiculo);

            return RedirectToAction("Index");
        }
    }
}
