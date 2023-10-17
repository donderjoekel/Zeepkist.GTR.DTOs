using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class PersonalBestGetLeaderboardResponseDTO
{
    public class Item
    {
        public RecordResponseModel Record { get; set; } = null!;
        public UserResponseModel User { get; set; } = null!;
    }

    public List<Item> Items { get; set; } = null!;
}
