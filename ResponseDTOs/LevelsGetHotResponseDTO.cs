using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.DTOs.ResponseDTOs;

public class LevelsGetHotResponseDTO
{
    public class Info
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public int RecordsCount { get; set; }
    }
    
    public List<Info> Levels { get; set; }
}
