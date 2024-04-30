/*
faça um programa de estante de livro, onde a estante é um vetor de até 10 livros. No final mostra a estante inteira ou o livro na posição escolhida;

titulo;
autor ou autores;
data lançamento;
editora;
edição;
isbm;
qtd pagina;
*/

int index = 0;
Livro livro = new Livro();
Livro[] estante = livro.CriarEstante();
int opcao = 0;
Console.WriteLine("-Guarde seus livros!!-");
do
{
    Console.WriteLine($"{index+1} livro:");
    Console.WriteLine("Digite o nome do livro:");
    livro.DefinirNome(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de autores do livro:");
    livro.DefinirQtdAutores(int.Parse(Console.ReadLine()));

    Console.WriteLine("Digite a data de lançamento do livro:");
    livro.DefinirDtLancamento(DateOnly.Parse(Console.ReadLine()));
    
    Console.WriteLine("Digite a editora do livro:");
    livro.DefinirEdicao(Console.ReadLine());

    Console.WriteLine("Digite o nome da editora livro:");
    livro.DefinirEditora(Console.ReadLine());

    Console.WriteLine("Digite ISBM do livro:");
    livro.DefinirIsbm(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de páginas do livro:");
    livro.DefinirQtdPagina(int.Parse(Console.ReadLine()));

    livro.GuardarLivro(livro, estante, index);
    index++;

    Console.WriteLine("Digite 0 para parar ou qualquer outro número para continuar.");
    opcao = int.Parse(Console.ReadLine());

} while (opcao != 0 || index > 10);

do
{
    Console.WriteLine("Deseja mostrar livro?\n digite a posição desejada, ou digite 0 para mostrar todos ou digite 11 para sair.");
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 0)
        livro.ListarTodosLivros(estante, index);
    else if (opcao < 11)
        livro.ListarLivro(estante, opcao - 1);
} while (opcao != 11);