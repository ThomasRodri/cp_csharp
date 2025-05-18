namespace challenge_dotnet.Aplication.DTOs;

public class CreateLocalizacaoPatioDto
{
    public int PosicaoX { get; set; }
    public int PosicaoY { get; set; }
    public string Descricao { get; set; } = string.Empty;
}
