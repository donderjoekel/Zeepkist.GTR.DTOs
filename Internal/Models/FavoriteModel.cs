namespace TNRD.Zeepkist.GTR.DTOs.Internal.Models;

public class FavoriteModel : BaseDirectusModel
{
    [JsonProperty("level")] public OneOf<int, LevelModel> Level { get; set; } = null!;
    [JsonProperty("user")] public OneOf<int, UserModel> User { get; set; } = null!;
}
