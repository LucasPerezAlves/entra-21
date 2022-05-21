using Entra21.ExemplosWhile;

Console.WriteLine(@"---------MENU------------
1 - Exemplo 01
2 - Exemplo 02");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exemplo01 nossoExemplo = new Exemplo01();
    nossoExemplo.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 nossoExemplo = new Exemplo02();
    nossoExemplo.Executar();
}
else if(opcaoDesejada == 3)
{
    Exemplo03 nossoExemplo = new Exemplo03();
    nossoExemplo.Executar();
}
else if (opcaoDesejada == 4)
{
    ExemploProfessor nossoExemplo = new ExemploProfessor();
    nossoExemplo.Executar();
}