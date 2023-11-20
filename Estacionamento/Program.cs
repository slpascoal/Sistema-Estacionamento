using Sistema_Estacionamento.Models;

decimal PrecoInicial = 0;
decimal PrecoPorHora = 0;

Console.WriteLine("Insira o preço inicial do estacionamento:");
PrecoInicial = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Insira o preço por hora:");
PrecoPorHora = Decimal.Parse(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(PrecoInicial, PrecoPorHora);

bool menu = true;
string OpcaoMenu = "0";

while(menu)
{
    Console.Write("\n");
    Console.WriteLine("Menu de Estacionamento");
    Console.WriteLine("- 1: Cadastrar veículo");
    Console.WriteLine("- 2: Remover veículo");
    Console.WriteLine("- 3: Listar veículos");
    Console.WriteLine("- 4: Encerrar");

    Console.WriteLine("Opção desejada: ");
    OpcaoMenu = Console.ReadLine();

    switch(OpcaoMenu)
    {
        case "1" :
            estacionamento.AdicionarVeiculo();
            break;
        case "2" :
            estacionamento.RemoverVeiculo();
            break;
        case "3" :
            estacionamento.ListarVeiculos();
            break;
        case "4" :
            estacionamento.AdicionarVeiculo();
            menu = false;
            break;
        default:
            Console.WriteLine("Erro: Insira uma opção válida");
            Thread.Sleep(2000);
            break;
    }
}