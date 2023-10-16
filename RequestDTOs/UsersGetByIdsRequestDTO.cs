namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class UsersGetByIdsRequestDTO : GenericGetRequestDTO
{
    public int[] Ids { get; set; } = null!;
}
