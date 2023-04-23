using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class LevelsGetPopularResponseDTO
{
    public List<LevelPopularityResponseModel> Levels { get; set; }
}
