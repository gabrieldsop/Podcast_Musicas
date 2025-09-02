class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host) //CTRL + . 'Inicializar no Construtor
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;


    public void AdicionarEpidosio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Poscast {Nome} apresentado por {Host}\n"); //cw + TAB 'Atalho WriteLine'
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios}.episódios.");
    }
}