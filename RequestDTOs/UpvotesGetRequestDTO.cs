namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class UpvotesGetRequestDTO : GenericGetRequestDTO
{
    public int? LevelId { get; set; }
    public string? LevelUid { get; set; }
    public string? LevelWorkshopId { get; set; }
    public int? UserId { get; set; }
    public string? UserSteamId { get; set; }
}
