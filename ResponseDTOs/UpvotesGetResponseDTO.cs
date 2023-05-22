using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class UpvotesGetResponseDTO
{
    public int TotalAmount { get; set; }
    public List<UpvoteResponseModel> Upvotes { get; set; } = null!;
}
