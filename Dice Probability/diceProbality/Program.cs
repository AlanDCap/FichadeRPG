List<string> combinations2d6 = new List<string>();
string[] d6results = { "1", "2", "3", "4", "5", "6" };
//int[] listaSucessos = { -1, 0, 0, 1, 1, 2 };

//geração da lista de combinações possíveis dos resultados de 2d6
foreach (string d in d6results)
{
    combinations2d6.Add(d + d6results[0]);
    combinations2d6.Add(d + d6results[1]);
    combinations2d6.Add(d + d6results[2]);
    combinations2d6.Add(d + d6results[3]);
    combinations2d6.Add(d + d6results[4]);
    combinations2d6.Add(d + d6results[5]);
}

for (int i = 0; i < combinations2d6.Count; i++)
{
    Console.WriteLine(combinations2d6[i]);
}

Console.WriteLine(combinations2d6.Count());
Console.WriteLine("Fim da lista 2d6");
Console.ReadKey();

//geração da lista de combinações possíveis dos resultados de 3d6
List<string> results2d6 = new List<string>();
List<string> combinations3d6 = new List<string>();
results2d6.AddRange(combinations2d6);


foreach (string d in results2d6)
{
    combinations3d6.Add(d + d6results[0]);
    combinations3d6.Add(d + d6results[1]);
    combinations3d6.Add(d + d6results[2]);
    combinations3d6.Add(d + d6results[3]);
    combinations3d6.Add(d + d6results[4]);
    combinations3d6.Add(d + d6results[5]);
}

for (int i = 0; i < combinations3d6.Count; i++)
{
    Console.WriteLine(combinations3d6[i]);
}

Console.WriteLine(combinations3d6.Count());
Console.WriteLine("Fim da lista 3d6");
Console.ReadKey();


//geração da lista de combinações possíveis dos resultados de 4d6
List<string> results3d6 = new List<string>();
List<string> combinations4d6 = new List<string>();
results3d6.AddRange(combinations3d6);


foreach (string d in results3d6)
{
    combinations4d6.Add(d + d6results[0]);
    combinations4d6.Add(d + d6results[1]);
    combinations4d6.Add(d + d6results[2]);
    combinations4d6.Add(d + d6results[3]);
    combinations4d6.Add(d + d6results[4]);
    combinations4d6.Add(d + d6results[5]);
}
for (int i = 0; i < combinations4d6.Count; i++)
{
    Console.WriteLine(combinations4d6[i]);
}
Console.WriteLine(combinations4d6.Count());
Console.WriteLine("Fim da lista 4d6");
Console.ReadKey();