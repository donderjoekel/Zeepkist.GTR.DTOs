namespace TNRD.Zeepkist.GTR.DTOs.Rabbit;

public class ProcessPersonalBestRequest
{
    public int Record { get; set; }
    public int User { get; set; }
    public string Level { get; set; } = null!;
    public float Time { get; set; }
}
