using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class StatsAggregateRequestDTO
{
    [QueryParam] [DefaultValue(null)] public int? Month { get; set; }
    [QueryParam] [DefaultValue(null)] public int? Year { get; set; }
}
