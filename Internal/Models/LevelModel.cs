namespace TNRD.Zeepkist.GTR.DTOs.Internal.Models;

public class LevelModel : BaseDirectusModel
{
    [JsonProperty("uid")] public string UniqueId { get; set; } = null!;
    [JsonProperty("wid")] public string? WorkshopId { get; set; }
    [JsonProperty("name")] public string Name { get; set; } = null!;
    [JsonProperty("author")] public string Author { get; set; } = null!;
    [JsonProperty("is_valid")] public bool IsValid { get; set; }
    [JsonProperty("time_author")] public float TimeAuthor { get; set; }
    [JsonProperty("time_gold")] public float TimeGold { get; set; }
    [JsonProperty("time_silver")] public float TimeSilver { get; set; }
    [JsonProperty("time_bronze")] public float TimeBronze { get; set; }
    [JsonProperty("thumbnail_url")] public string ThumbnailUrl { get; set; } = null!;
    [JsonProperty("created_by")] public OneOf<int, UserModel> CreatedBy { get; set; }
}
