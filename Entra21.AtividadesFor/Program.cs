


using Entra21.AtividadesFor;

Console.Write(@"--------------MENU---------------
1 - Atividade 01
2 - Atividade 02
3 - Atividade 03
4 - Atividade 04");

Console.Write("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());


if (opcaoDesejada == 1)
{
    AtividadeFor1 nossaAtividade = new AtividadeFor1();
    nossaAtividade.Executar();
}
if (opcaoDesejada == 8)
{
    AtividadeFor8while nossaAtividade = new AtividadeFor8while();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 5)
{
    AtividadeFor5while nossaAtividade = new AtividadeFor5while();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 12)
{
    AtividadeFor12while nossaAtividade = new AtividadeFor12while();
    nossaAtividade.Executar();
}
