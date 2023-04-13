using TNRD.Zeepkist.GTR.DTOs.Internal.Models;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class UpvoteResponseModel
{
    public int Id { get; set; }
    public UserResponseModel? User { get; set; }
    public LevelResponseModel? Level { get; set; }
    
    public static implicit operator UpvoteResponseModel(UpvoteModel model)
    {
        return new UpvoteResponseModel()
        {
            Id = model.Id,
            User = model.User,
            Level = model.Level
        };
    }
    
    public static implicit operator UpvoteResponseModel(OneOf<int, UpvoteModel> model)
    {
        return new UpvoteResponseModel()
        {
            Id = model.Match<int>(i => i, m => m.Id),
            User = model.Match<UserResponseModel?>(i => null, m => m.User),
            Level = model.Match<LevelResponseModel?>(i => null, m => m.Level)
        };
    }
}
