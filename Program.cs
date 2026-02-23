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
        Console.WriteLine("");
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
