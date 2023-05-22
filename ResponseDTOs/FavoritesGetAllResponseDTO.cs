using System.Collections.Generic;
using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class FavoritesGetAllResponseDTO
{
    public int TotalAmount { get; set; }
    public List<FavoriteResponseModel> Favorites { get; set; } = null!;
}
