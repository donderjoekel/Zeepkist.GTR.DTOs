using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class VotesGetAverageRequestDTO : GenericGetRequestDTO
{
    [QueryParam] [DefaultValue(null)] public string? Level { get; set; }
}
