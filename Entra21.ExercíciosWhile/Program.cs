using Entra21.ExercíciosWhile;

using Entra21.ExercíciosWhile;


Console.WriteLine(@"-----------MENU-----------
1 - Atividade 01
2 - Atividade 02
3 - Atividade 03
4 - Atividade 04
5 - Atividade 05
6 - Atividade 06
7 - Atividade 07");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    AtividadeWhile1 nossaAtividade = new AtividadeWhile1();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 2)
{
    AtividadeWhile2 nossaAtividade = new AtividadeWhile2();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 3)
{
    AtividadeWhile3 nossaAtividade = new AtividadeWhile3();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 4)
{
    AtividadeWhile4 nossaAtividade = new AtividadeWhile4();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 5)
{
    AtividadeWhile5 nossaAtividade = new AtividadeWhile5();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 6)
{
    AtividadeWhile6 nossaAtividade = new AtividadeWhile6();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 6)
{
    AtividadeWhile7 nossaAtividade = new AtividadeWhile7();
    nossaAtividade.Executar();
}
