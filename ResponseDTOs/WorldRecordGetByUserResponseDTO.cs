using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class WorldRecordGetByUserResponseDTO
{
    public int TotalAmount { get; set; }
    public List<WorldRecordResponseModel> Items { get; set; } = null!;
}
