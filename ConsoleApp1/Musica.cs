class Musica
{
    public Musica(Banda artista, string nome) //Construtor, inicializando seus atributos ou realizando outras tarefas necessárias antes de usar o objeto;
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //Atributo com leitura e escrita
    public string Descricao  => $"A música {Nome} pertence a banda {Artista}"; 
    

    public void ExibirFicharTecnica()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no Plano.");

        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus.");
        }
            }
}