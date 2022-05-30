using Entra21.AtividadesOrientacaoObjetos.Exercício01;
using Entra21.AtividadesOrientacaoObjetos.Exercício02;

Console.Write(@"--------------MENU--------------
1 -- Atividade 01
2 -- Atividade 02
3 -- Atividade 03
");

Console.WriteLine("Digite a opcão desejada:");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExemploLivro nossaAtividade = new ExemploLivro();
    nossaAtividade.Executar();
}
else if (opcaoDesejada == 2)
{
    ExemploTemperatura nossaAtividade = new ExemploTemperatura();
    nossaAtividade.Executar();
}