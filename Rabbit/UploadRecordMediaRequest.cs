namespace TNRD.Zeepkist.GTR.DTOs.Rabbit;

public class UploadRecordMediaRequest
{
    public int Id { get; set; }
    public string GhostData { get; set; } = null!;
    public string ScreenshotData { get; set; } = null!;
}
