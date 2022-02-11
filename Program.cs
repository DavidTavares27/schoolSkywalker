/* ATIVIDADE: Fazer um sistema de escola que leia o nome do aluno
 e as notas dos 4 bimestres e a quantidade total de faltas, calcular a 
 media geral do ano e  decidir baseado nas regras abaixo se o aluno passou, 
 reprovou ou ficou de de recuperacao:

Se a nota do aluno for maior que 7  aluno aprovado.
Se nota menor que 5 reprovado.
Se nota entre 5 e 7 aluno em recuperação.

Obs: se quantidade de faltas for maior ou igual a  50  aluno também esta  de recuperação.*/

double notaPrimeiroBimestre, notaSegundoBimestre, notaTerceiroBimestre, notaQuartoBimestre, mediaFinal;
double totalFaltas = 0;

Console.WriteLine("Seja Bem ao Sistema de notas da Escola Skywalker");
Console.WriteLine("Digite o nome do aluno");
var nomeDoAluno = Console.ReadLine();

//Digite as notas
Console.Write("Digite a nota do 1° Bimestre: ");
notaPrimeiroBimestre = double.Parse(Console.ReadLine());

Console.Write("Digite a nota do 2° Bimestre: ");
notaSegundoBimestre = double.Parse(Console.ReadLine());

Console.Write("Digite a nota do 3° Bimestre: ");
notaTerceiroBimestre = double.Parse(Console.ReadLine());

Console.Write("Digite a nota do 4° Bimestre: ");
notaQuartoBimestre = double.Parse(Console.ReadLine());

mediaFinal = (notaPrimeiroBimestre + notaSegundoBimestre + notaTerceiroBimestre + notaQuartoBimestre)/4;
Console.WriteLine($"A média final do aluno {nomeDoAluno} é: {mediaFinal}");

Console.Write("Digite a quantidade total de faltas: ");
totalFaltas = double.Parse(Console.ReadLine());

if (mediaFinal < 5)
{
  Console.Write($"O aluno {nomeDoAluno} foi Reprovado");
}
else if ((mediaFinal >= 5) && (mediaFinal < 7))
{
  Console.Write($"O aluno {nomeDoAluno} está em Recuperação");
}
else if ((mediaFinal>= 7) && (totalFaltas > 50))
{
  Console.Write($"O aluno {nomeDoAluno} está em recuperação");
}
else
{
  Console.Write($"O aluno {nomeDoAluno} está Aprovado");
}

