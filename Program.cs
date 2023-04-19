/*
Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

Os produtos terão os seguintes atributos:
string Nome
float Preco
bool Promocao (se está em promoção ou não)

O sistema deverá ter as seguintes funcionalidades:
CadastrarProduto
ListarProdutos
MostrarMenu
Crie função(ões) para otimizar o código.
Incremente o que achar necessário. Utilize sua lógica e sua criatividade.
*/

//criar menu cwl
//Cadastrar produtos 
//Cadastrar preco
//cadastrar promocao

string[] produto = new string [2];
float[] preco = new float [2];
string[] promocao = new string [2];

static string CadastrarProdutos(int i)
{
    Console.WriteLine($"Digite o {i}º produto: ");
    return Console.ReadLine();
}

static float CadastrarPreco(int i)
{
    Console.WriteLine($"Digite o preco do {i}º produto: ");
    return float.Parse(Console.ReadLine());
}

static string CadastrarPromocao(int i)
{
    Console.WriteLine($"Digite se o {i}º produto esta em promocao S/N: ");
    return Console.ReadLine();
}






string escolhaMenu = "";
do
{
    Console.WriteLine(@$"
***** Mercado Abelha *****
1- Cadastrar Produtos
2- Listar Produtos
0- Sair
");
    escolhaMenu = Console.ReadLine();

    switch (escolhaMenu)
    {
        case "1":
        for (var i = 0; i < 2; i++)
        {
            produto[i] = CadastrarProdutos(i+1);
            preco[i] = CadastrarPreco(i+1) ;
            promocao[i] = CadastrarPromocao(i+1);
        }
            break;

        case "2":
        for (var i = 0; i < 2; i++)
        {
            
        Console.WriteLine(@$"
        Aqui esta a sua lista de produtos:
        Produto: {produto[i]}
        Preco: {preco[i]}
        Esta em promocao?: {promocao[i]}
        ");
        }

            break;

        case "0":
        Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            break;

        default:
            Console.WriteLine($"Digite um numero valido!");
            break;
    }


} while (escolhaMenu != "0");

