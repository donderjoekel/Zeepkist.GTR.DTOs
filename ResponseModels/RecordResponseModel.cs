namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class RecordResponseModel
{
    public int Id { get; set; }
    public float? Time { get; set; }
    public float[]? Splits { get; set; }
    public bool? IsValid { get; set; }
    public string? GameVersion { get; set; }
    public string? ModVersion { get; set; }
    public string? Level { get; set; }
    public UserResponseModel? User { get; set; }
}
