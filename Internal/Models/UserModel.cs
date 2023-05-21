namespace TNRD.Zeepkist.GTR.DTOs.Internal.Models;

public class UserModel : BaseDirectusModel
{
    [JsonProperty("steam_id")] public string SteamId { get; set; } = null!;
    [JsonProperty("steam_name")] public string? SteamName { get; set; }
    [JsonProperty("discord_id")] public string? DiscordId { get; set; }
    [JsonProperty("position")] public int? Position { get; set; }
    [JsonProperty("score")] public int? Score { get; set; }
}
