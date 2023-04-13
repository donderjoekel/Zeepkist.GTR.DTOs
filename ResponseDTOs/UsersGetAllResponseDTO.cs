using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class UsersGetAllResponseDTO
{
    public int TotalAmount { get; set; }
    public List<UserResponseModel> Users { get; set; }
}
