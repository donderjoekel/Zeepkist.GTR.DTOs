namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class FavoriteResponseModel
{
    public int Id { get; set; }
    public LevelResponseModel? Level { get; set; }
    public UserResponseModel? User { get; set; }
}
