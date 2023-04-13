namespace TNRD.Zeepkist.GTR.DTOs.Internal.Models;

public class VoteModel : BaseDirectusModel
{
    [JsonProperty("score")] public int Score { get; set; }
    [JsonProperty("category")] public int Category { get; set; }
    [JsonProperty("user")] public OneOf<int, UserModel> User { get; set; }
    [JsonProperty("level")] public OneOf<int, LevelModel> Level { get; set; }
}

public class AverageVoteModel
{
    public class AverageScoreModel
    {
        [JsonProperty("score")] public float Value { get; set; }
    }

    public class CountModel
    {
        [JsonProperty("id")] public int Value { get; set; }
    }

    [JsonProperty("level")] public int Level { get; set; }
    [JsonProperty("category")] public int Category { get; set; }
    [JsonProperty("avg")] public AverageScoreModel AverageScore { get; set; }
    [JsonProperty("count")] public CountModel Count { get; set; }
}
