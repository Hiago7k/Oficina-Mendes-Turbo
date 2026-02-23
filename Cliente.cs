
namespace Oficina_Mendes_Turbo;

internal class Cliente
{
    public Cliente(string nome, string cPF, string numeroDeTelefone)
    {
        Nome = nome;
        CPF = cPF;
        NumeroDeTelefone = numeroDeTelefone;
    }

    public string Nome { get; }
    public string CPF { get; }
    public string NumeroDeTelefone { get; }
}
