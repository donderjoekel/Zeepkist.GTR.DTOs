namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class RecordsSubmitRequestDTO
{
    public string Level { get; set; } = null!;
    public int User { get; set; }
    public float Time { get; set; }
    public float[] Splits { get; set; } = null!;
    public string GhostData { get; set; } = null!;
    public string ScreenshotData { get; set; } = null!;
    public bool IsValid { get; set; }
    public string GameVersion { get; set; } = null!;
    public string ModVersion { get; set; } = null!;
}
