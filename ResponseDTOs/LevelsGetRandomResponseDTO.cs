using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class LevelsGetRandomResponseDTO
{
    public List<LevelResponseModel> Levels { get; set; } = null!;
}
