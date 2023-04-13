using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class RecordsGetResponseDTO
{
    public int TotalAmount { get; set; }
    public List<RecordResponseModel> Records { get; set; }
}
