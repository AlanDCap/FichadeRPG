// See https://aka.ms/new-console-template for more information

using DiceMechanics;

int rolarD4 = 0;
Dice d = new Dice();
Console.WriteLine("Digite quantas vezes deseja rolar d4");
rolarD4 = int.Parse(Console.ReadLine());
Console.WriteLine($"d4 rolls: {d.RollD4(rolarD4)}\n");

Console.WriteLine("Digite quantas vezes deseja rolar d6");
rolarD4 = int.Parse(Console.ReadLine());
Console.WriteLine($"d6 rolls: {d.RollD6(rolarD4)}\n");

string rolar;
Console.WriteLine("Digite os dados que deseja rolar.\n Ex: 3d8");
rolar = Console.ReadLine();
Console.WriteLine($"{rolar}: {d.Roll(rolar)}\n");