Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
int adultosBebem = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
int adultosNaoBebem = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Crianças........................................: ");
int criancas = int.Parse(Console.ReadLine() ?? "0");

double carne = (adultosBebem + adultosNaoBebem) * 0.4 + criancas * 0.2;
double acompanhamentos = (adultosBebem + adultosNaoBebem + criancas) * 0.2;
double cerveja = adultosBebem * 2.0;
double refrigerante = adultosNaoBebem * 0.5 + criancas * 0.5;
double agua = (adultosBebem + adultosNaoBebem + criancas) * 0.4;

Console.WriteLine("\nResultados:");
Console.WriteLine($"Carne.............: {carne:N1}KG");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}KG");
Console.WriteLine($"Cerveja...........: {cerveja:N1}L");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}L");
Console.WriteLine($"Água..............: {agua:N1}L");

