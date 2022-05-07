using Entra21.ExercíciosWhile;

Console.WriteLine(@"---------MENU------------
1 - Exemplo 01");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    AtividadeWhile7 nossoExemplo = new AtividadeWhile7();
    nossoExemplo.Executar();
}

