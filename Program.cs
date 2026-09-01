

Album albumDoQuen = new Album();
albumDoQuen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my live";
musica1.Duracion = 213;

Musica  musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracion = 360;


albumDoQuen.AdicionarMusica(musica1);
albumDoQuen.AdicionarMusica(musica2);

albumDoQuen.ExibirMusicaDoAlbum();