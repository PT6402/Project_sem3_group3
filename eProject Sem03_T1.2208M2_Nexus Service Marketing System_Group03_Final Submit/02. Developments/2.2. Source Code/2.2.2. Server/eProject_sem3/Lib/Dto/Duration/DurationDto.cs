using System;
namespace Lib.Dto.Duration
{
    public class DurationDto
    {
        public int? id { get; set; }
        public int package_id { get; set; }
        public string? time { get; set; }
        public float price { get; set; }
        public string? validate { get; set; }
        public string? description { get; set; }
    }
}

