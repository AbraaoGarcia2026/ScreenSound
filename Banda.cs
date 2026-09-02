
class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album  album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}