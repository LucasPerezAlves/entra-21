using Entra21.AtividadesListas;

Console.WriteLine(@"-------MENU------
1 - Atividade 01
2 - Atividade 02
3 - Atividade 03");

Console.WriteLine("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    AtividadeLista01 nossaAtividade = new AtividadeLista01();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 2)
{
    AtividadeLista02 nossaAtividade = new AtividadeLista02();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 3)
{
    AtividadeLista03 nossaAtividade = new AtividadeLista03();
    nossaAtividade.Executar();
}