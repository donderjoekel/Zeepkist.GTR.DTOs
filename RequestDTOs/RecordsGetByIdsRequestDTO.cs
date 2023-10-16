namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

[AutoGenerateBuilder]
public class RecordsGetByIdsRequestDTO : GenericGetRequestDTO
{
    public int[] Ids { get; set; } = null!;
}
