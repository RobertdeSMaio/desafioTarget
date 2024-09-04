using System.Xml.Serialization;
using Receita.Models;

//Tecnica test para TargetSistemas

//Teste 1 - qual será o valor da variável SOMA?

int indice = 13;
int soma = 0;
int K = 0;

while(K < indice){
  K = K + 1;
  soma = soma + K;
}
Console.WriteLine($"Resultado de Soma e: {soma}"); // Resultado de Soma e: 91

//Teste 2 - Dado a sequência de Fibonacci

bool IsFibonacci(int n) //Verifica se o numero pertence a sequencia
{
  if(n == 0 || n == 1)// casos para numeros menores ou igual a 1
  return true;

  int a = 0, b = 1, c = a + b;
  while(c <= n)
  {
    if(c == n)
    return true;

    a = b;
    b = c;
    c = a + b;
  }
  return false;
}

Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci: ");
if(int.TryParse(Console.ReadLine(), out int numero))
{
  if(IsFibonacci(numero)){
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
  }
  else{
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
  }
}
else{
  Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
}

//! Teste 3 - faturamento diário de uma distribuidora

// string faturamentojson = "faturamento.json";

// string faturamentos = faturamentojson;

// if(faturamentos == null || !faturamentos.Any())
// {
//   Console.WriteLine("Nenhum dado de faturamento disponivel");
//   return;
// }
// // Calcular o menor valor de faturamento
//     var menorFaturamento = faturamentos.Min(f => f.Faturamento);
//     Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");

//     // Calcular o maior valor de faturamento
//     var maiorFaturamento = faturamentos.Max(f => f.Faturamento);
//     Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");

//     // Filtrar apenas os dias com faturamento (ignorar zeros)
//     var diasComFaturamento = faturamentos.Where(f => f.Faturamento > 0).ToList();

//     // Calcular a média mensal
//     var mediaMensal = diasComFaturamento.Average(f => f.Faturamento);
//     Console.WriteLine($"Média mensal de faturamento: {mediaMensal}");

//     // Contar o número de dias com faturamento superior à média
//     var diasAcimaDaMedia = diasComFaturamento.Count(f => f.Faturamento > mediaMensal);
//     Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaDaMedia}");

// static List<Faturamento> LerFaturamentoDeArquivo(string caminho)
// {
//   try
//   {
//   string json = File.ReadAllText(caminho);
//   return JsonConvert.DeserializeObject<List<faturamento>>(json);
//   }
//   catch (Exception ex)
//   {
//   Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
//   return null;
//   }
// }

//Teste 4

// Definindo os valores de faturamento por estado
  var faturamentos = new Dictionary<string, double>
  {
    { "SP", 67836.43 },
    { "RJ", 36678.66 },
    { "MG", 29229.88 },
    { "ES", 27165.48 },
    { "Outros", 19849.53 }
  };

// Calculando o valor total de faturamento
  double valorTotal = 0;
  foreach (double valor in faturamentos.Values)
  {
  valorTotal += valor;
  }
// Calculando e exibindo o percentual de representação de cada estado
  Console.WriteLine("Percentual de representação por estado:");
  foreach (var estado in faturamentos)
  {
  double percentual = (estado.Value / valorTotal) * 100;
  Console.WriteLine($"{estado.Key}: {percentual:F2}%");
  }

//Teste 5 - Escreva um programa que inverta os caracteres de um string.

// Definindo a string a ser invertida
Console.Write("Digite a string para inverter: ");
string input = Console.ReadLine();

// Invertendo a string
string resultado = InverterString(input);

// Exibindo o resultado
Console.WriteLine("String invertida: " + resultado);

static string InverterString(string str)
{
  char[] caracteres = str.ToCharArray(); // Converte a string em um array de caracteres
  int comprimento = caracteres.Length;

  // Inverte os caracteres do array
  for (int i = 0; i < comprimento / 2; i++)
  {
    char temp = caracteres[i];
    caracteres[i] = caracteres[comprimento - 1 - i];
    caracteres[comprimento - 1 - i] = temp;
  }

  // Converte o array de volta para uma string
  return new string(caracteres);
}