using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class LevelsGetPointsResponseDTO
{
    public List<LevelPointsResponseModel> Items { get; set; } = null!;
}
