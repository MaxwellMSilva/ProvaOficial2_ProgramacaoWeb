namespace Dominio.Entidades
{
    public class Veiculo
    {
        public Veiculo(string veiculo_Marca, string veiculo_Modelo, string veiculo_Ano, string veiculo_Quilometragem)
        {
            Veiculo_Marca = veiculo_Marca;
            Veiculo_Modelo = veiculo_Modelo;
            Veiculo_Ano = veiculo_Ano;
            Veiculo_Quilometragem = veiculo_Quilometragem;
        }

        public int Id { get; set; }
        public string Veiculo_Marca { get; set; }
        public string Veiculo_Modelo { get; set; }
        public string Veiculo_Ano { get; set; }
        public string Veiculo_Quilometragem { get; set; }

        public void AtualizarVeiculo(string marca, string modelo, string ano, string quilometragem)
        {
            this.Veiculo_Marca = marca;
            this.Veiculo_Modelo = modelo;
            this.Veiculo_Ano = ano;
            this.Veiculo_Quilometragem = quilometragem;
        }
    }
}
