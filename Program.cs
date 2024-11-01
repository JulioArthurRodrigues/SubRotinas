ExibirTitulo();
Console.Write("Informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
bool ehPar = DefinirPar(numero);

ExibirResultado(numero, ehPar);

void ExibirTitulo()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--------------------");
    Console.WriteLine("--- Par ou Ímpar ---");
    Console.WriteLine("-------------------\n");
    Console.ResetColor();
}

bool DefinirPar(int numero)
{
    bool ehPar = numero % 2 == 0;
    return ehPar;
}

void ExibirResultado(int numero, bool ehPar)
{
    Console.WriteLine($"O número {numero} é {(ehPar ? "Par" : "Ímpar")}");
}