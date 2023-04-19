using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class LevelsGetPopularResponseDTO
{
    public class Info
    {
        public LevelResponseModel Level { get; set; }
        public int RecordsCount { get; set; }
    }
    
    public List<Info> Levels { get; set; }
}
