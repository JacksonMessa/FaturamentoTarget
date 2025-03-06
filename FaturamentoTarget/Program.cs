using FaturamentoTarget;

Faturamento faturamento = new Faturamento();

Console.WriteLine("O maior valor foi: " + faturamento.maiorValor());
Console.WriteLine("O menor valor foi: " + faturamento.menorValor());
Console.WriteLine("O menor valor foi sem contar dias sem faturamento foi: " + faturamento.menorValorSemContarZero());
Console.WriteLine("O numero de dias acima da média foi: " + faturamento.diasAcimaDaMedia());