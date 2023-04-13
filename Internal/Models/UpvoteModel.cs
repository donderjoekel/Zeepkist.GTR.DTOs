namespace TNRD.Zeepkist.GTR.DTOs.Internal.Models;

public class UpvoteModel : BaseDirectusModel
{
    [JsonProperty("level")] public OneOf<int, LevelModel> Level { get; set; }
    [JsonProperty("user")] public OneOf<int, UserModel> User { get; set; }
}
