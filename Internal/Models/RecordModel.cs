namespace TNRD.Zeepkist.GTR.DTOs.Internal.Models;

public class RecordModel : BaseDirectusModel
{
    [JsonProperty("time")] public float Time { get; set; }
    [JsonProperty("splits")] public string? Splits { get; set; }
    [JsonProperty("ghost_url")] public string GhostUrl { get; set; } = null!;
    [JsonProperty("screenshot_url")] public string ScreenshotUrl { get; set; } = null!;
    [JsonProperty("is_best")] public bool IsBest { get; set; }
    [JsonProperty("is_valid")] public bool IsValid { get; set; }
    [JsonProperty("is_wr")] public bool IsWorldRecord { get; set; }
    [JsonProperty("game_version")] public string GameVersion { get; set; } = null!;
    [JsonProperty("level")] public OneOf<int, LevelModel> Level { get; set; }
    [JsonProperty("user")] public OneOf<int, UserModel> User { get; set; }
}
