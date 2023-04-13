using TNRD.Zeepkist.GTR.DTOs.Internal.Models;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class VoteResponseModel
{
    public int Id { get; set; }
    public int? Category { get; set; }
    public int? Score { get; set; }
    public UserResponseModel? User { get; set; }
    public LevelResponseModel? Level { get; set; }
    
    public static implicit operator VoteResponseModel(VoteModel model)
    {
        return new VoteResponseModel()
        {
            Id = model.Id,
            Score = model.Score,
            Category = model.Category,
            User = model.User,
            Level = model.Level
        };
    }
    
    public static implicit operator VoteResponseModel(OneOf<int, VoteModel> model)
    {
        return new VoteResponseModel()
        {
            Id = model.Match<int>(i => i, m => m.Id),
            Score = model.Match<int?>(i => null, m => m.Score),
            Category = model.Match<int?>(i => null, m => m.Category),
            User = model.Match<UserResponseModel?>(i => null, m => m.User),
            Level = model.Match<LevelResponseModel?>(i => null, m => m.Level)
        };
    }
}
