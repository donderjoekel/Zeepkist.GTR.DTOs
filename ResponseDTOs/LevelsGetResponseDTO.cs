using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class LevelsGetResponseDTO
{
    public int TotalAmount { get; set; }
    public List<LevelResponseModel> Levels { get; set; } = null!;
}
