using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class RecordsGetRecentResponseDTO
{
    public List<RecordResponseModel> Records { get; set; } = null!;
}
