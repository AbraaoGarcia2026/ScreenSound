
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracion = 273;
musica1.Disponivel  = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracion = 373;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica1.ExibirNomeEArtista();