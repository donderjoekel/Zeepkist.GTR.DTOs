using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class RecordsGetByIdsResponseDTO
{
    public List<RecordResponseModel> Items { get; set; } = null!;
}
