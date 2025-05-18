namespace challenge_dotnet.Domain.MotoRepository;

public class Moto
{
    public Guid Id { get; set; }
    public string Placa { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public Guid FilialId { get; set; }
    public Guid LocalizacaoAtualId { get; set; }

    public Filial Filial { get; set; } = new Filial();
    public LocalizacaoPatio LocalizacaoAtual { get; set; } = new LocalizacaoPatio();

}
