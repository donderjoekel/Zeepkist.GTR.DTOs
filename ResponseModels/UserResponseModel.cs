namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class UserResponseModel
{
    public int Id { get; set; }
    public string? SteamId { get; set; }
    public string? SteamName { get; set; }
    public string? DiscordId { get; set; }
    public int? Position { get; set; }
    public int? Score { get; set; }
    public StatsResponseModel? Stats { get; set; }
}
