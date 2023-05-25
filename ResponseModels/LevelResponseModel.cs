using TNRD.Zeepkist.GTR.DTOs.Internal.Models;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class LevelResponseModel
{
    public int Id { get; set; }
    public string? UniqueId { get; set; }
    public string? WorkshopId { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public bool? IsValid { get; set; }
    public float? TimeAuthor { get; set; }
    public float? TimeGold { get; set; }
    public float? TimeSilver { get; set; }
    public float? TimeBronze { get; set; }
    public string? ThumbnailUrl { get; set; }
    public int? Rank { get; set; }
    public int? Points { get; set; }
    public RecordResponseModel? WorldRecord { get; set; }

    public static implicit operator LevelResponseModel(OneOf<int, LevelModel> levelModel)
    {
        return new LevelResponseModel()
        {
            Id = levelModel.Match(i => i, model => model.Id),
            UniqueId = levelModel.Match<string?>(i => null, model => model.UniqueId),
            WorkshopId = levelModel.Match<string?>(i => null, model => model.WorkshopId),
            Name = levelModel.Match<string?>(i => null, model => model.Name),
            Author = levelModel.Match<string?>(i => null, model => model.Author),
            IsValid = levelModel.Match<bool?>(i => null, model => model.IsValid),
            TimeAuthor = levelModel.Match<float?>(i => null, model => model.TimeAuthor),
            TimeGold = levelModel.Match<float?>(i => null, model => model.TimeGold),
            TimeSilver = levelModel.Match<float?>(i => null, model => model.TimeSilver),
            TimeBronze = levelModel.Match<float?>(i => null, model => model.TimeBronze),
            ThumbnailUrl = levelModel.Match<string?>(i => null, model => model.ThumbnailUrl),
            Rank = levelModel.Match<int?>(i => null, model => model.Rank),
            Points = levelModel.Match<int?>(i => null, model => model.Points)
        };
    }

    public static implicit operator LevelResponseModel(LevelModel levelModel)
    {
        return new LevelResponseModel()
        {
            Id = levelModel.Id,
            UniqueId = levelModel.UniqueId,
            WorkshopId = levelModel.WorkshopId,
            Name = levelModel.Name,
            Author = levelModel.Author,
            IsValid = levelModel.IsValid,
            TimeAuthor = levelModel.TimeAuthor,
            TimeGold = levelModel.TimeGold,
            TimeSilver = levelModel.TimeSilver,
            TimeBronze = levelModel.TimeBronze,
            ThumbnailUrl = levelModel.ThumbnailUrl,
            Rank = levelModel.Rank,
            Points = levelModel.Points
        };
    }
}
