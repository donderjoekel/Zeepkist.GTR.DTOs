namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class MediaResponseModel
{
    public int Id { get; set; }
    public RecordResponseModel Record { get; set; } = null!;
    public string GhostUrl { get; set; } = null!;
    public string ScreenshotUrl { get; set; } = null!;
}
