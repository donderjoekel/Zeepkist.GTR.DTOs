using System.ComponentModel;

namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class GenericGetRequestDTO
{
    [QueryParam, DefaultValue(100)] public int? Limit { get; set; }
    [QueryParam, DefaultValue(0)] public int? Offset { get; set; }
}
