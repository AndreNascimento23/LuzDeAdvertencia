
Console.Clear();

string T,P,R;

Console.WriteLine("---Simulador de Luz de Advertência---\n");

Console.WriteLine("*******************************");
Console.WriteLine("***(A)tivado ** (D)esativado***");
Console.WriteLine("*******************************\n");

Console.Write("Sensor de temperatura...: ");
T = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.Write("Sensor de pressão.......: ");
P = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.Write("Sensor de rotação.......: ");
R = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.WriteLine();


if(T == "A" || P == "A" || R == "D" )
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A luz de advertência estará ATIVADA.");
    Console.ResetColor();
}
if (T != "A" && P != "A" && R != "D")
{
    Console.WriteLine("A luz de advertência estará DESATIVADA.");
}