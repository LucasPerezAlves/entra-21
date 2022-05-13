using Entra21.AtividadeLista1;

Console.Write(@"--------------MENU---------------
1 - Atividade 01
2 - Atividade 02
3 - Atividade 03
4 - Atividade 04");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Atividade1Lista01 nossaAtividade = new Atividade1Lista01();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 2)
{
    Atividade2Lista01 nossaAtividade = new Atividade2Lista01();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 3)
{
    Atividade3Lista01 nossaAtividade = new Atividade3Lista01();
    nossaAtividade.Executar();
}