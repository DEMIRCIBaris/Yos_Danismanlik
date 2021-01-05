using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.DTO.YosQuestionsDTO
{
    public class YosQuestionsUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }
        public string DocumentUrl { get; set; }
        public string URL { get; set; }
    }
}
