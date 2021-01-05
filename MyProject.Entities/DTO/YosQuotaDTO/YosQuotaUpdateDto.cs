using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.DTO.YosQuotaDTO
{
    public class YosQuotaUpdateDto
    {
        public int Id { get; set; }
        public string UniversityName { get; set; }
        public string Departments { get; set; }
        public string Time { get; set; }
        public string Quota { get; set; }
    }
}
