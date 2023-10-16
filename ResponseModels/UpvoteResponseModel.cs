namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class UpvoteResponseModel
{
    public int Id { get; set; }
    public int User { get; set; }
    public string Level { get; set; } = null!;
}
