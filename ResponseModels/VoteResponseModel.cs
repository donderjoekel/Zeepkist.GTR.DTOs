namespace TNRD.Zeepkist.GTR.DTOs.ResponseModels;

public class VoteResponseModel
{
    public int Id { get; set; }
    public int? Category { get; set; }
    public int? Score { get; set; }
    public UserResponseModel? User { get; set; }
    public string? Level { get; set; }
}
