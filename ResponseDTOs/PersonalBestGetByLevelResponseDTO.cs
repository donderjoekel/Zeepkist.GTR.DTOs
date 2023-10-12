using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class PersonalBestGetByLevelResponseDTO
{
    public int TotalAmount { get; set; }
    public List<PersonalBestResponseModel> Items { get; set; } = null!;
}
