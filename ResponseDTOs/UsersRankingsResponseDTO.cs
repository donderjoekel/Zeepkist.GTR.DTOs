using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class UsersRankingsResponseDTO
{
    public class Ranking
    {
        public UserResponseModel User { get; set; } = null!;
        public int AmountOfWorldRecords { get; set; }
        public int Position { get; set; }
        public double Score { get; set; }
    }

    public int TotalAmount { get; set; }
    public List<Ranking> Rankings { get; set; } = null!;
}
