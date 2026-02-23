namespace Oficina_Mendes_Turbo;

internal class Avaliacao
{
    public Avaliacao(string veiculo, string placaDoVeiculo, Cliente cliente)
    {
        Veiculo = veiculo;
        PlacaDoVeiculo = placaDoVeiculo;
        Cliente = cliente;
    }

    public string Veiculo { get; }
    public string PlacaDoVeiculo { get; }
    public Cliente Cliente;
}
