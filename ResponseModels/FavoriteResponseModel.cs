namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class FavoriteResponseModel
{
    public int Id { get; set; }
    public string? Level { get; set; }
    public UserResponseModel? User { get; set; }
}
