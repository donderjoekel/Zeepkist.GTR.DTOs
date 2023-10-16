using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class UsersGetByIdsResponseDTO
{
    public List<UserResponseModel> Items { get; set; } = null!;
}
