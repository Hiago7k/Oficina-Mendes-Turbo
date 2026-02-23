using Oficina_Mendes_Turbo;

Console.WriteLine("==============================");
Console.WriteLine("*******OFICINA MENDES********");
Console.WriteLine("==============================");


Console.WriteLine("\nBem vindo! Como nos Podemos lhe ajudar hoje?");


Console.WriteLine("1. Marcar uma Avaliacao: ");
Console.WriteLine("2. Solicitar um Servico: ");
Console.WriteLine("3. Limpeza de Veiculo: ");
Console.WriteLine("4. Encerrar Auto Atendimento: ");
int resposta = Convert.ToInt32(Console.ReadLine()!);

switch (resposta)
{
    case 1:
        // Marcar Avaliacao
        Console.Clear();
        Console.WriteLine("Para continuar seu atendimento, preencha seus dados abaixo!");
        Console.WriteLine("Digite seu Nome Completo: ");
        string nomeDoCliente = Console.ReadLine()!;
        Console.WriteLine("Digite seu CPF: ");
        string cpfDoCliente = Console.ReadLine()!;
        Console.WriteLine("Digite seu Numero de Telefone com o dd (00) 1234-2456");
        string numeroDoCliente = Console.ReadLine()!;


        Cliente cliente = new Cliente(nomeDoCliente, cpfDoCliente, numeroDoCliente);
        Console.WriteLine($"{cliente.Nome} {cliente.CPF} {cliente.NumeroDeTelefone}");

        // Avaliacao
        Console.WriteLine("Qual o Veiculo: ");
        string veiculo = Console.ReadLine()!;
        Console.WriteLine("Placa do veiculo: ");
        string placa = Console.ReadLine()!;

        Avaliacao avaliacao = new Avaliacao(veiculo, placa, cliente);
        Console.WriteLine();
        Console.WriteLine($" {avaliacao.Veiculo} {avaliacao.PlacaDoVeiculo} {avaliacao.Cliente.Nome} {avaliacao.Cliente.CPF}");


        break;
    case 2:
        // Solicitar Servico
        break;
    case 3:
        // Limpeza de Veiculo
        break;
    case 4:
        // Encerar chat
       break;
    default:
        // Opcao Invalida
        break;
}
