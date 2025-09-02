/*Banda travis = new Banda("Travis Scott");

Album albumTravisScott = new Album("Utopia");

Musica musica1 = new Musica(travis, "FEIN") //Atribuição de demais valores (Inicializador de Propriedades)
{
    Duracao = 214,
    Disponivel = false,
};

Musica musica2 = new Musica(travis, "Till Further Notice")
{
    Duracao = 354,
    Disponivel = true,
};

albumTravisScott.AdicionarMusica(musica1);
albumTravisScott.AdicionarMusica(musica2);
travis.AdicionarAlbum(albumTravisScott);

musica1.ExibirFicharTecnica();
musica2.ExibirFicharTecnica();
albumTravisScott.ExibirMusicasAlbum();
travis.ExibirDiscografia();*/

Episodio ep1 = new(1, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Maria");

Episodio ep2 = new(2, "Técnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Gabriel");
ep2.AdicionarConvidados("Manoela");

Episodio ep3 = new(3, "Técnicas de Manipulação", 75);
ep3.AdicionarConvidados("Matheus");
ep3.AdicionarConvidados("Diego");

Podcast podcast = new("especial", "Flavia");
podcast.AdicionarEpidosio(ep1);
podcast.AdicionarEpidosio(ep2);
podcast.AdicionarEpidosio(ep3);
podcast.ExibirDetalhes();