using Newtonsoft.Json;
using TesteJson;
var dadosStr = File.ReadAllText(@"C:\Users\joaor\Downloads\dados.json");
var dados = JsonConvert.DeserializeObject<FaturamentoDiario[]>(dadosStr);
if(dados != null)
{
    double recebe = 0, NumMaior = 0, NumMenor = 0, media = 0;
    int diasSupMed = 0;
    foreach (var dado in dados)
    {
        Console.WriteLine($"{dado.Dia} - {dado.Valor}");
        if (dado.Valor != 0)
            media += dado.Valor;
    }
    media /= dados.Length;

    foreach(var dado in dados)
    {
        if (dado.Valor > recebe && dado.Valor > NumMaior)
            NumMaior = dado.Valor;
        else if (dado.Valor < NumMenor && dado.Valor != 0 || NumMenor == 0)
            NumMenor = dado.Valor;

        if (dado.Valor < media)
            diasSupMed++;

        recebe = dado.Valor;
    }
    
    Console.WriteLine($"{NumMaior} é o maior faturamento");
    Console.WriteLine($"{NumMenor} é o menor faturamento");
    Console.WriteLine($"{diasSupMed} dias foram superiores a média");
}
