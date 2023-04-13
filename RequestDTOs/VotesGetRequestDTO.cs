using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class VotesGetRequestDTO : GenericGetRequestDTO
{
    [QueryParam, DefaultValue(null)] public int? LevelId { get; set; }
    [QueryParam, DefaultValue(null)] public string? LevelUid { get; set; }
    [QueryParam, DefaultValue(null)] public string? LevelWorkshopId { get; set; }
    [QueryParam, DefaultValue(null)] public string? UserSteamId { get; set; }
    [QueryParam, DefaultValue(null)] public int? UserId { get; set; }
}
