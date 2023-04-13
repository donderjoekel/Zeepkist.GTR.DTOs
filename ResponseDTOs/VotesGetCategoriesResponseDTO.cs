using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class VotesGetCategoriesResponseDTO
{
    public class Category
    {
        public string DisplayName { get; set; } = null!;
        public int Value { get; set; }
    }
    
    public List<Category> Categories { get; set; } = null!;
}
