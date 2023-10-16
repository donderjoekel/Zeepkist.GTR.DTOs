namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class RecordResponseModel
{
    public int Id { get; set; }
    public float Time { get; set; }
    public float[]? Splits { get; set; }
    public bool IsValid { get; set; }
    public string GameVersion { get; set; } = null!;
    public string ModVersion { get; set; } = null!;
    public string Level { get; set; } = null!;
    public int User { get; set; }
}
