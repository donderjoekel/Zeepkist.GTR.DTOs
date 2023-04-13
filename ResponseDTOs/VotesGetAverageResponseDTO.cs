using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class VotesGetAverageResponseDTO
{
    public class AverageLevelScore
    {
        public int Level { get; set; }
        public int Category { get; set; }
        public float AverageScore { get; set; }
        public int AmountOfVotes { get; set; }
    }
    
    public List<AverageLevelScore> AverageScores { get; set; }
}
