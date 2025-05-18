using challenge_dotnet.Domain.MotoRepository;

public class LocalizacaoPatio
{
    public Guid Id { get; set; }
    public int PosicaoX { get; set; }
    public int PosicaoY { get; set; }
    public string Descricao { get; set; } = string.Empty;

    public ICollection<Moto> Motos { get; set; } = new List<Moto>();

}
