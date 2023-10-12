namespace TNRD.Zeepkist.GTR.DTOs.RequestDTOs;

public class PersonalBestGetByLevelAndUserRequestDTO : GenericGetRequestDTO
{
    public int Level { get; set; }
    public int User { get; set; }
}
