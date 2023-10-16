namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

public class RecordsGetByIdsRequestDTO : GenericGetRequestDTO
{
    public int[] Ids { get; set; } = null!;
}
