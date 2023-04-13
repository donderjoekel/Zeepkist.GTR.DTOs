using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class RecordsGetRequestDTO : GenericGetRequestDTO
{
    [QueryParam, DefaultValue(null)] public int? LevelId { get; set; }
    [QueryParam, DefaultValue(null)] public string? LevelUid { get; set; }
    [QueryParam, DefaultValue(null)] public string? LevelWorkshopId { get; set; }
    [QueryParam, DefaultValue(null)] public string? UserSteamId { get; set; }
    [QueryParam, DefaultValue(null)] public int? UserId { get; set; }
    [QueryParam, DefaultValue(null)] public bool? BestOnly { get; set; }
    [QueryParam, DefaultValue(null)] public bool? ValidOnly { get; set; }
    [QueryParam, DefaultValue(null)] public bool? InvalidOnly { get; set; }
    [QueryParam, DefaultValue(null)] public bool? WorldRecordOnly { get; set; }
    [QueryParam, DefaultValue(null)] public float? MinimumTime { get; set; }
    [QueryParam, DefaultValue(null)] public float? MaximumTime { get; set; }
    [QueryParam, DefaultValue(null)] public string? GameVersion { get; set; }
    [QueryParam, DefaultValue(null)] public string? Sort { get; set; }
}
