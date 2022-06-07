using Entra21.AtividadesListas;

Console.WriteLine(@"-------MENU------
1 - Atividade 01
2 - Atividade 02");

Console.WriteLine("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    AtividadeLista01 nossaAtividade = new AtividadeLista01();
    nossaAtividade.Executar();
}
