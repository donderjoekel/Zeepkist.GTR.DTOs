namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class LevelPopularityResponseModel
{
    public LevelResponseModel Level { get; set; } = null!;
    public int RecordsCount { get; set; }
}
