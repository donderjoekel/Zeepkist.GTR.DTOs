using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class VotesGetResponseDTO
{
    public int TotalAmount { get; set; }
    public List<VoteResponseModel> Votes { get; set; }
}
