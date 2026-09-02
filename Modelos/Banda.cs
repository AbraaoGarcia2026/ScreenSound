namespace ScreenSound.Modelos;

class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>();
    public List<Album> Albuns => albuns;
    
    public string Nome { get; }
    public double Media => notas.Average();

    public void AdicionarAlbum(Album  album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}