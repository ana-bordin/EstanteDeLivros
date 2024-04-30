/*
faça um programa de estante de livro, onde a estante é um vetor de até 10 livros. No final mostra a estante inteira ou o livro na posição escolhida;
*/

using System.ComponentModel.Design;

int index = 0;
Livro[] estante = new Livro[10];

void ListarTodosLivros(Livro[] estante, int index)
{
    for (int i = 0; i < index; i++)
        ListarLivro(estante, i);
}
void ListarLivro(Livro[] estante, int index)
{
    if (estante[index].Nome != null)
    {
        Console.WriteLine($"Nome do Livro: {estante[index].Nome}");
        Console.WriteLine("Nome dos autores:");
        for (int j = 0; j < estante[index].Autores.Length; j++)
            Console.WriteLine($"{estante[index].Autores[j]}");
        Console.WriteLine($"Data de lancamento: {estante[index].DataLancamento}");
        Console.WriteLine($"Editora: {estante[index].Editora}");
        Console.WriteLine($"Edição: {estante[index].Edicao}");
        Console.WriteLine($"IBSM: {estante[index].Ibsm}");
        Console.WriteLine($"Quantidade de páginas: {estante[index].QtdPagina}");
    }
}
int Menu()
{
    Console.WriteLine("Digite a ação que quer realizar:\n1- Cadastrar Livro;\n2-Listar todos os Livros\n3-Buscar Livro pelo indice;\n4-Para sair;");
    return int.Parse(Console.ReadLine());

}
Livro CadastrarLivro()
{
    Livro livro = new Livro();
    Console.WriteLine("Digite o nome do livro:");
    livro.DefinirNome(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de autores do livro:");
    livro.DefinirQtdAutores(int.Parse(Console.ReadLine()));

    //Console.WriteLine("Digite a data de lançamento do livro:");
    //livro.DefinirDtLancamento(DateOnly.Parse(Console.ReadLine()));

    Console.WriteLine("Digite a editora do livro:");
    livro.DefinirEdicao(Console.ReadLine());

    Console.WriteLine("Digite o nome da editora livro:");
    livro.DefinirEditora(Console.ReadLine());

    Console.WriteLine("Digite ISBM do livro:");
    livro.DefinirIsbm(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de páginas do livro:");
    livro.DefinirQtdPagina(int.Parse(Console.ReadLine()));

    estante[index] = livro;
    index++;
    
    return livro;
}

Console.WriteLine("-Guarde seus livros!!-");
do
{
    switch (Menu())
    {
        case 1:
            Console.WriteLine($"{index + 1} livro:");
            CadastrarLivro();
            break;

        case 2:
            ListarTodosLivros(estante, index);
            break;

        case 3:
            Console.WriteLine("Informe o indice do livro:");
            ListarLivro(estante, int.Parse(Console.ReadLine()));
            break;

        case 4:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Digite uma opção válida!");
            break;
    }

} while (true);

