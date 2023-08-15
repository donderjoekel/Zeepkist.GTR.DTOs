namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class LevelResponseModel
{
    public int Id { get; set; }
    public string? UniqueId { get; set; }
    public string? WorkshopId { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public bool? IsValid { get; set; }
    public float? TimeAuthor { get; set; }
    public float? TimeGold { get; set; }
    public float? TimeSilver { get; set; }
    public float? TimeBronze { get; set; }
    public string? ThumbnailUrl { get; set; }
    public int? Rank { get; set; }
    public int? Points { get; set; }
    public RecordResponseModel? WorldRecord { get; set; }
}
