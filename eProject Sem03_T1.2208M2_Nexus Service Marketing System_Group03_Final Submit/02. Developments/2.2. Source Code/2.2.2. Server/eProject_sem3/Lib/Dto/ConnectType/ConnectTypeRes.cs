using System;
namespace Lib.Dto.ConnectType
{
    public class ConnectTypeRes
    {
        public int? id { get; set; }
        public string name { get; set; } = null!;
        public string firstLetter { get; set; } = null!;
        public string? description { get; set; }
        public float deposit { get; set; }
    }
}

