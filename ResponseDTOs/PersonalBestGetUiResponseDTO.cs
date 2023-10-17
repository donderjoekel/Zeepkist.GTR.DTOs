using TNRD.Zeepkist.GTR.DTOs.ResponseModels;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class PersonalBestGetUiResponseDTO
{
    public RecordResponseModel Record { get; set; } = null!;
    public UserResponseModel User { get; set; } = null!;
}
