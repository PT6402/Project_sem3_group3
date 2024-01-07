using System;
namespace Lib.Dto.ConnectType
{
	public class ConnectTypeDto
	{
        public int? id { get; set; }
        public string name { get; set; } = null!;
        public string firstLetter { get; set; } = null!;
        public string? description { get; set; }
        public float deposit { get; set; }

        public List<Packages> packages { get; set; } = new List<Packages>();
    }
}

