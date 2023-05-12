//DRY - Don´t Repeat Yourself

ExibirDivisor();

Console.WriteLine("a");

ExibirDivisor();

Console.WriteLine("b");

ExibirDivisor();

Console.WriteLine("c");

ExibirDivisor();

Console.WriteLine("d");

ExibirDivisor();

Console.WriteLine("e");

ExibirDivisor();

void ExibirDivisor()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("--------------------------------------");
    Console.ResetColor();
}