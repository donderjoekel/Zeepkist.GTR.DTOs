using System;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class RecordResponseModel
{
    public int Id { get; set; }
    public float? Time { get; set; }
    public float[]? Splits { get; set; }
    public string? GhostUrl { get; set; }
    public string? ScreenshotUrl { get; set; }
    public bool? IsBest { get; set; }
    public bool? IsValid { get; set; }
    public bool? IsWorldRecord { get; set; }
    public string? GameVersion { get; set; }
    public LevelResponseModel? Level { get; set; }
    public UserResponseModel? User { get; set; }
    public DateTime? DateCreated { get; set; }
}
