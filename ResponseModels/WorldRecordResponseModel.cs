using System;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class WorldRecordResponseModel
{
    public int Id { get; set; }
    public int Record { get; set; }
    public int User { get; set; }
    public string Level { get; set; } = null!;
    public DateTime? PeriodStart { get; set; }
    public DateTime? PeriodEnd { get; set; }
}
