using screenSound;
using screenSound.Modelos;

namespace ScreenSound.Modelos;

public class Album : IAvaliavel
{
    public Album(string nome)
    {
        Nome = nome;
    }
    
    private List<Musica> musicas = new List<Musica>();
    public List<Musica> Musicas => musicas;
    private List<Avaliacao> notas = new();
    
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

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
}