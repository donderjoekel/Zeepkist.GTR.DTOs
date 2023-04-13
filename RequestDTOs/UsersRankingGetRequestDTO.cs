using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class UsersRankingGetRequestDTO
{
    [QueryParam, DefaultValue(null)] public int? UserId { get; set; }
    [QueryParam, DefaultValue(null)] public string? SteamId { get; set; }
}
