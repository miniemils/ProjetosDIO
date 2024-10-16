using src.Models;

Console.Write("Deseja cadastrar quantas pessoas? ");
int N = Convert.ToInt32(Console.ReadLine());

List<Pessoa> listaDeHospedes = new List<Pessoa>();

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Cadastro da {i+1}ª pessoa:");
    string? nome;
    while(true)
    {
        try
        {
            Console.Write("Digite o primeiro nome: ");
            nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome não pode estar vazio.");
            }
            break;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    string? sobrenome;
    while(true)
    {
        try
        {
            Console.Write("Digite o sobrenome: ");
            sobrenome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sobrenome))
            {
                throw new ArgumentException("O sobrenome não pode estar vazio.");
            }
            break;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    Pessoa pessoa = new Pessoa(nome, sobrenome);
    listaDeHospedes.Add(pessoa);
}

string? tipoSuite;
decimal valorDiaria = 00.00m;
int capacidadeSuite = 0;
while(true)
{
    Console.WriteLine("Escolha o tipo de suíte. \nOpções: suíte comum, suíte premium e suíte executiva.");
    tipoSuite = Console.ReadLine();
    switch(tipoSuite)
    {
        case "suite comum":
            Console.WriteLine("O valor da diária é R$ 30,00, com capacidade para até 2 pessoas.");
            valorDiaria = 30.00M;
            capacidadeSuite = 2;
            break;
        case "suite executiva":
            Console.WriteLine("O valor da diária é R$ 60,00, com capacidade para até 4 pessoas.");
            valorDiaria = 60.00M;
            capacidadeSuite = 4;
            break;
        case "suite premium":
            Console.WriteLine("O valor da diária é R$ 90,00, com capacidade para até 6 pessoas.");
            valorDiaria = 90.00M;
            capacidadeSuite = 6;
            break;
        default:
            Console.WriteLine("Tipo de suíte inválido. Por favor, tente novamente.");
            continue;
    }
break;
}
Suite suite = new Suite(tipoSuite, capacidadeSuite, valorDiaria);

Console.WriteLine("Você deseja reservar a suíte por quantos dias?");
int diasReservados = Convert.ToInt32(Console.ReadLine());
Reserva reserva = new Reserva(diasReservados, suite);

try
{
    Console.WriteLine(reserva.CadastrarHospedes(listaDeHospedes));
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

Console.WriteLine($"O valor da diária é R${reserva.CalcularValorDiaria().ToString("F2")}");