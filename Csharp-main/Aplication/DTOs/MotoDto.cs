namespace challenge_dotnet.Aplication.DTOs;

public class MotoDto
{
    public Guid Id { get; set; }
    public string Modelo { get; set; } = string.Empty;
    public string Placa { get; set; } = string.Empty;
    public Guid FilialId { get; set; }
    public Guid LocalizacaoPatioId { get; set; }
}
