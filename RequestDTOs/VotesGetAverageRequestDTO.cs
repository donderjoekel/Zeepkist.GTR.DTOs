using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class VotesGetAverageRequestDTO : GenericGetRequestDTO
{
    [QueryParam, DefaultValue(null)] public int? LevelId { get; set; }
}
