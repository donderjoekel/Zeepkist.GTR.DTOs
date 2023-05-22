using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class VotesGetAverageResponseDTO
{
    public class AverageLevelScore
    {
        public LevelResponseModel Level { get; set; } = null!;
        public float AverageScore { get; set; }
        public int AmountOfVotes { get; set; }
    }
    
    public List<AverageLevelScore> AverageScores { get; set; } = null!;
}
