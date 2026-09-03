namespace ScreenSound.Modelos;

public class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    
    private List<Musica> musicas = new List<Musica>();
    public List<Musica> Musicas => musicas;
    
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    
    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este album inteiro voce precisa de {DuracaoTotal}");
    }

    public static int ContadorDeObjetos = 0;
    public Album()
    {
        ContadorDeObjetos++;
    }
}