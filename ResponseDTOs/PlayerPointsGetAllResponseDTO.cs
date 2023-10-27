using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class PlayerPointsGetAllResponseDTO
{
    public int TotalAmount { get; set; }
    public List<PlayerPointsResponseModel> Items { get; set; } = null!;
}
