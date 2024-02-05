using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class LevelGetPointsRequestDTO : GenericGetRequestDTO
{
    [QueryParam] [DefaultValue(false)] public bool? SortByPoints { get; set; }
    [QueryParam] [DefaultValue(false)] public bool? Ascending { get; set; }
}
