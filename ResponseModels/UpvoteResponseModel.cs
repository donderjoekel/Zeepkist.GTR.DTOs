namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class UpvoteResponseModel
{
    public int Id { get; set; }
    public UserResponseModel? User { get; set; }
    public LevelResponseModel? Level { get; set; }
}
