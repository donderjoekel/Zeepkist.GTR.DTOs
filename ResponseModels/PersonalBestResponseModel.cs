using System;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class PersonalBestResponseModel
{
    public int Id { get; set; }
    public RecordResponseModel Record { get; set; } = null!;
    public UserResponseModel User { get; set; } = null!;
    public LevelResponseModel Level { get; set; } = null!;
    public DateTime? PeriodStart { get; set; }
    public DateTime? PeriodEnd { get; set; }
}
