/*mesmo que o código gere listas até 12d6, o que será utlizado para o sistema de RPG é apenas até o 6d6.
 * Além disso, esse código na visa ser executado sempre, mas apenas uma vez para gerar as combinações, 
 * que servirão de base para análise das estatísticas de resultados das rolagens de dado*/


string nomeArquivo = "Rolagens.dat";
StreamWriter escritor = new StreamWriter(nomeArquivo, true);

//geração da lista de combinações possíveis dos resultados de 2d6
string[] d6results = { "-1;", "0;", "0;", "1;", "1;", "2;" };
List<string> combinations2d6 = new List<string>();
foreach (string d in d6results)
{
    combinations2d6.Add(d + d6results[0]);
    combinations2d6.Add(d + d6results[1]);
    combinations2d6.Add(d + d6results[2]);
    combinations2d6.Add(d + d6results[3]);
    combinations2d6.Add(d + d6results[4]);
    combinations2d6.Add(d + d6results[5]);
}

//registro dos resultados em arquivo.
escritor.WriteLine("Lista de 2d6");
for (int i = 0; i < combinations2d6.Count; i++)
{
    escritor.WriteLine(combinations2d6[i]);
}

escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"O total de combinações é {combinations2d6.Count()}");
Console.WriteLine("Fim da lista 2d6");

/*Abaixo cria-se uma nova lista para realizar a combinação dos resultados de 3d6.
A lista combinations2d6 é adicionada inteira à lista combinations3d6, e as iterações
são feitas a partir dela, acrescentando os valores de d6results.
Dessa forma, não é necessário fazer verificação de valores repetidos.*/

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

escritor.WriteLine("Lista de 3d6");
for (int i = 0; i < combinations3d6.Count; i++)
{
    escritor.WriteLine(combinations3d6[i]);
}

escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"O total de combinações é {combinations3d6.Count()}");
Console.WriteLine("Fim da lista 3d6");

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

escritor.WriteLine("Lista de 4d6");
for (int i = 0; i < combinations4d6.Count; i++)
{
    escritor.WriteLine(combinations4d6[i]);
}
escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"O total de combinações é {combinations4d6.Count()}");
Console.WriteLine("Fim da lista 4d6");

//geração da lista de combinações possíveis dos resultados de 5d6
List<string> results4d6 = new List<string>();
List<string> combinations5d6 = new List<string>();
results4d6.AddRange(combinations4d6);

foreach (string d in results4d6)
{
    combinations5d6.Add(d + d6results[0]);
    combinations5d6.Add(d + d6results[1]);
    combinations5d6.Add(d + d6results[2]);
    combinations5d6.Add(d + d6results[3]);
    combinations5d6.Add(d + d6results[4]);
    combinations5d6.Add(d + d6results[5]);
}

escritor.WriteLine("Lista de 5d6");
for (int i = 0; i < combinations5d6.Count; i++)
{
    escritor.WriteLine(combinations5d6[i]);
}
escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations5d6.Count()}");
Console.WriteLine("fim da lista 5d6");

//geração da lista de combinações possíveis dos resultados de 5d6
List<string> results5d6 = new List<string>();
List<string> combinations6d6 = new List<string>();
results5d6.AddRange(combinations5d6);


foreach (string d in results5d6)
{
    combinations6d6.Add(d + d6results[0]);
    combinations6d6.Add(d + d6results[1]);
    combinations6d6.Add(d + d6results[2]);
    combinations6d6.Add(d + d6results[3]);
    combinations6d6.Add(d + d6results[4]);
    combinations6d6.Add(d + d6results[5]);
}

escritor.WriteLine("Lista de 6d6");
for (int i = 0; i < combinations6d6.Count; i++)
{
    escritor.WriteLine(combinations6d6[i]);
}
escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations6d6.Count()}");
Console.WriteLine("fim da lista 6d6");


//geração da lista de combinações possíveis dos resultados de 7d6
List<string> results6d6 = new List<string>();
List<string> combinations7d6 = new List<string>();
results6d6.AddRange(combinations6d6);


foreach (string d in results6d6)
{
    combinations7d6.Add(d + d6results[0]);
    combinations7d6.Add(d + d6results[1]);
    combinations7d6.Add(d + d6results[2]);
    combinations7d6.Add(d + d6results[3]);
    combinations7d6.Add(d + d6results[4]);
    combinations7d6.Add(d + d6results[5]);
}

escritor.WriteLine("Lista de 7d6");
for (int i = 0; i < combinations7d6.Count; i++)
{
    escritor.WriteLine(combinations7d6[i]);
}
escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations7d6.Count()}");
Console.WriteLine("fim da lista 7d6");


//geração da lista de combinações possíveis dos resultados de 8d6
List<string> results7d6 = new List<string>();
List<string> combinations8d6 = new List<string>();
results7d6.AddRange(combinations7d6);

foreach (string d in results7d6)
{
    combinations8d6.Add(d + d6results[0]);
    combinations8d6.Add(d + d6results[1]);
    combinations8d6.Add(d + d6results[2]);
    combinations8d6.Add(d + d6results[3]);
    combinations8d6.Add(d + d6results[4]);
    combinations8d6.Add(d + d6results[5]);
}

escritor.WriteLine("Lista de 8d6");
for (int i = 0; i < combinations8d6.Count; i++)
{
    escritor.WriteLine(combinations8d6[i]);
}
escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations8d6.Count()}");
Console.WriteLine("fim da lista 8d6");

//geração da lista de combinações possíveis dos resultados de 9d6
List<string> results8d6 = new List<string>();
List<string> combinations9d6 = new List<string>();
results8d6.AddRange(combinations8d6);


foreach (string d in results8d6)
{
    combinations9d6.Add(d + d6results[0]);
    combinations9d6.Add(d + d6results[1]);
    combinations9d6.Add(d + d6results[2]);
    combinations9d6.Add(d + d6results[3]);
    combinations9d6.Add(d + d6results[4]);
    combinations9d6.Add(d + d6results[5]);
}

escritor.WriteLine("Lista de 9d6");
for (int i = 0; i < combinations9d6.Count; i++)
{
    escritor.WriteLine(combinations9d6[i]);
}
escritor.WriteLine("\n");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations9d6.Count()}");
Console.WriteLine("fim da lista 9d6");

/*
//geração da lista de combinações possíveis dos resultados de 10d6
List<string> results9d6 = new List<string>();
List<string> combinations10d6 = new List<string>();
results9d6.AddRange(combinations9d6);

foreach (string d in results9d6)
{
    combinations10d6.Add(d + d6results[0]);
    combinations10d6.Add(d + d6results[1]);
    combinations10d6.Add(d + d6results[2]);
    combinations10d6.Add(d + d6results[3]);
    combinations10d6.Add(d + d6results[4]);
    combinations10d6.Add(d + d6results[5]);
}
for (int i = 0; i < combinations10d6.Count; i++)
{
    escritor.WriteLine(combinations10d6[i]);
}
escritor.WriteLine("\nFim da lista 10d6");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations10d6.Count()}");
Console.WriteLine("fim da lista 10d6");

//geração da lista de combinações possíveis dos resultados de 11d6
List<string> results10d6 = new List<string>();
List<string> combinations11d6 = new List<string>();
results10d6.AddRange(combinations9d6);

foreach (string d in results10d6)
{
    combinations11d6.Add(d + d6results[0]);
    combinations11d6.Add(d + d6results[1]);
    combinations11d6.Add(d + d6results[2]);
    combinations11d6.Add(d + d6results[3]);
    combinations11d6.Add(d + d6results[4]);
    combinations11d6.Add(d + d6results[5]);
}
for (int i = 0; i < combinations11d6.Count; i++)
{
    escritor.WriteLine(combinations11d6[i]);
}
escritor.WriteLine("\nFim da lista 11d6");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations11d6.Count()}");
Console.WriteLine("fim da lista 11d6");

//geração da lista de combinações possíveis dos resultados de 12d6
List<string> results11d6 = new List<string>();
List<string> combinations12d6 = new List<string>();
results11d6.AddRange(combinations11d6);


foreach (string d in results11d6)
{
    combinations12d6.Add(d + d6results[0]);
    combinations12d6.Add(d + d6results[1]);
    combinations12d6.Add(d + d6results[2]);
    combinations12d6.Add(d + d6results[3]);
    combinations12d6.Add(d + d6results[4]);
    combinations12d6.Add(d + d6results[5]);
}
for (int i = 0; i < combinations12d6.Count; i++)
{
    escritor.WriteLine(combinations12d6[i]);
}
escritor.WriteLine("\nFim da lista 12d6");
escritor.Flush();
Console.WriteLine($"o total de combinações é {combinations12d6.Count()}");
Console.WriteLine("fim da lista 12d6");