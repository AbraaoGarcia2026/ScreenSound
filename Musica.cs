
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    
    public string Nome { get; }
    public Banda Artista  { get; }
    public int Duracion  { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Musica: {Nome}");
        Console.WriteLine($"Nome do Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracion}");
        if (Disponivel == true)
        {
            Console.WriteLine($"Disponivel no plano.");
        }
        else
        {
            Console.WriteLine($"Adquira o plano Plus+");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}
