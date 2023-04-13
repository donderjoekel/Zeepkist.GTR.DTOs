using TNRD.Zeepkist.GTR.DTOs.Internal.Models;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class FavoriteResponseModel
{
    public int Id { get; set; }
    public LevelResponseModel? Level { get; set; }
    public UserResponseModel? User { get; set; }

    public static implicit operator FavoriteResponseModel(FavoriteModel model)
    {
        return new FavoriteResponseModel()
        {
            Id = model.Id,
            Level = model.Level,
            User = model.User
        };
    }

    public static implicit operator FavoriteResponseModel(OneOf<int, FavoriteModel> model)
    {
        return new FavoriteResponseModel()
        {
            Id = model.Match<int>(i => i, m => m.Id),
            Level = model.Match<LevelResponseModel?>(i => null, m => m.Level),
            User = model.Match<UserResponseModel?>(i => null, m => m.User)
        };
    }
}
