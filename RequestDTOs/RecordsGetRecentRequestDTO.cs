using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class RecordsGetRecentRequestDTO : GenericGetRequestDTO
{
    [QueryParam] [DefaultValue(null)] public string? Level { get; set; }
    [QueryParam] [DefaultValue(null)] public string? UserSteamId { get; set; }
    [QueryParam] [DefaultValue(null)] public int? UserId { get; set; }
    [QueryParam] [DefaultValue(null)] public bool? BestOnly { get; set; }
}
