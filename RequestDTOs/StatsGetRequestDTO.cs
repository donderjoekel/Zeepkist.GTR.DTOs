using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

public class StatsGetRequestDTO
{
    [QueryParam] public int UserId { get; set; }
    [QueryParam] [DefaultValue(null)] public int? Month { get; set; }
    [QueryParam] [DefaultValue(null)] public int? Year { get; set; }
}
