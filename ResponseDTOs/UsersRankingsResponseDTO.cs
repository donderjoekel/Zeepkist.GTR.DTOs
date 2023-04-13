using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class UsersRankingsResponseDTO
{
    public class Ranking
    {
        public UserModel User { get; set; }
        public int AmountOfWorldRecords { get; set; }
        public int Position { get; set; }
    }

    public class UserModel
    {
        public int Id { get; set; }
        public string SteamId { get; set; } = null!;
        
        public string? SteamName { get; set; }
    }

    public int TotalAmount { get; set; }
    public List<Ranking> Rankings { get; set; }
}
