using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Livro
{
    public string Nome;
    public string[] Autores;
    public DateOnly DataLancamento;
    public string Editora;
    public string Edicao;
    public string Ibsm;
    public int QtdPagina;

    public Livro()
    {
    }
    public void DefinirNome(string n)
    {
        this.Nome = n;
    }
    public void DefinirQtdAutores(int qtd)
    {
        string[] autores = new string[qtd];
        DefinirAutores(autores, qtd);
    }
    public void DefinirAutores(string[] autores, int qtd)
    {
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"{i+1}º autor/a:");
            autores[i] = Console.ReadLine();
        }
        this.Autores = autores;
    }
    public void DefinirDtLancamento(DateOnly dtl)
    {
        this.DataLancamento = dtl;
    }
    public void DefinirEditora(string e)
    {
        this.Editora = e;
    }
    public void DefinirEdicao(string edicao)
    {
        this.Edicao = edicao;
    }
    public void DefinirIsbm(string i)
    {
        this.Ibsm = i;
    }
    public void DefinirQtdPagina(int p)
    {
        this.QtdPagina = p;
    }
    public Livro[] CriarEstante()
    {
        Livro[] estante = new Livro[10];
        return estante;
    }
    public void GuardarLivro(Livro livro, Livro[] estante, int index)
    {
        estante[index] = livro;
    }

    public void ListarLivro(Livro[] estante, int index)
    {
        if (estante[index].Nome != null)
        {
            Console.WriteLine($"Nome do Livro: {estante[index].Nome}");
            Console.WriteLine("Nome dos autores:");  
            for (int j = 0; j < Autores.Length; j++)
                Console.WriteLine($"{Autores[j]}");
            Console.WriteLine($"Data de lancamento: {estante[index].DataLancamento}");
            Console.WriteLine($"Editora: {estante[index].Editora}");
            Console.WriteLine($"Edição: {estante[index].Edicao}");
            Console.WriteLine($"IBSM: {estante[index].Ibsm}");
            Console.WriteLine($"Quantidade de páginas: {estante[index].QtdPagina}");
        }
    }
    public void ListarTodosLivros(Livro[] estante, int index)
    {
        for (int i = 0; i < index; i++)
            ListarLivro(estante, i);
    }
}

