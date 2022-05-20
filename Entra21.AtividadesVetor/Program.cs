

using Entra21.AtividadesVetor;

Console.Write(@"--------------MENU---------------
1 - Atividade 01
2 - Atividade 02
3 - Atividade 03
4 - Atividade 04
5 - Atividade 05
");

Console.Write("Digite a atividade desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    AtividadeVetor1 nossaAtividade = new AtividadeVetor1();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 2)
{
    AtividadesVetor2 nossaAtividade = new AtividadesVetor2();
    nossaAtividade.Executar();

}
else if (opcaoDesejada == 3)
{
    AtividadesVetor3 nossaAtividade = new AtividadesVetor3();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 4)
{
    AtividadesVetor4 nossaAtividade = new AtividadesVetor4();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 5)
{
    AtividadesVetor5 nossaAtividade = new AtividadesVetor5();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 6)
{
    AtividadeVetor6 nossaAtividade = new AtividadeVetor6();
    nossaAtividade.Executar();
}
