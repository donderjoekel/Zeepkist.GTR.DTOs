using TNRD.Zeepkist.GTR.DTOs.Internal.Models;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class UserResponseModel
{
    public int Id { get; set; }
    public string? SteamId { get; set; }
    public string? SteamName { get; set; }

    public static implicit operator UserResponseModel(OneOf<int, UserModel> userModel)
    {
        return new UserResponseModel()
        {
            Id = userModel.Match<int>(i => i, u => u.Id),
            SteamId = userModel.Match<string?>(i => null, u => u.SteamId),
            SteamName = userModel.Match<string?>(i => null, u => u.SteamName)
        };
    }

    public static implicit operator UserResponseModel(UserModel userModel)
    {
        return new UserResponseModel()
        {
            Id = userModel.Id,
            SteamId = userModel.SteamId,
            SteamName = userModel.SteamName
        };
    }
}
