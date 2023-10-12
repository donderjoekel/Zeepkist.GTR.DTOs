using System;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class WorldRecordResponseModel
{
    public int Id { get; set; }
    public RecordResponseModel Record { get; set; } = null!;
    public UserResponseModel User { get; set; } = null!;
    public string Level { get; set; } = null!;
    public DateTime? PeriodStart { get; set; }
    public DateTime? PeriodEnd { get; set; }
}
