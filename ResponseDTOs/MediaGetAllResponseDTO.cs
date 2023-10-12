using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class MediaGetAllResponseDTO
{
    public int TotalAmount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<MediaResponseModel> Items { get; set; } = null!;
}
