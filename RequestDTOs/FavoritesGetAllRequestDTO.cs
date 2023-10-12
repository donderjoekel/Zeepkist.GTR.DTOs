namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class FavoritesGetAllRequestDTO : GenericGetRequestDTO
{
    public string? Level { get; set; }
    public int? UserId { get; set; }
    public string? UserSteamId { get; set; }
}
