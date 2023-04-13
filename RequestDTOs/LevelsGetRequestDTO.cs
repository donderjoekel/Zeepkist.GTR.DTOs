using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class LevelsGetRequestDTO : GenericGetRequestDTO
{
    [QueryParam, DefaultValue(null)] public string? Author { get; set; }
    [QueryParam, DefaultValue(null)] public string? Name { get; set; }
    [QueryParam, DefaultValue(null)] public string? Uid { get; set; }
    [QueryParam, DefaultValue(null)] public string? WorkshopId { get; set; }
    [QueryParam, DefaultValue(null)] public bool? ValidOnly { get; set; }
    [QueryParam, DefaultValue(null)] public bool? InvalidOnly { get; set; }
    [QueryParam, DefaultValue(null)] public string? Sort { get; set; }
}
