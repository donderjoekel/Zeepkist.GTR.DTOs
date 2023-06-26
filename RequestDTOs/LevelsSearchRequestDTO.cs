using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class LevelsSearchRequestDTO : GenericGetRequestDTO
{
    [QueryParam, DefaultValue(null)] public string? Query { get; set; }
    [QueryParam, DefaultValue(null)] public float? MinAuthor { get; set; }
    [QueryParam, DefaultValue(null)] public float? MaxAuthor { get; set; }
    [QueryParam, DefaultValue(null)] public float? MinGold { get; set; }
    [QueryParam, DefaultValue(null)] public float? MaxGold { get; set; }
    [QueryParam, DefaultValue(null)] public float? MinSilver { get; set; }
    [QueryParam, DefaultValue(null)] public float? MaxSilver { get; set; }
    [QueryParam, DefaultValue(null)] public float? MinBronze { get; set; }
    [QueryParam, DefaultValue(null)] public float? MaxBronze { get; set; }
    [QueryParam, DefaultValue(null)] public string? Sort { get; set; }
}
