using System;
namespace Lib.Dto.CallCharge
{
	public class CallChargeDto
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public float Price { get; set; }
        public string Unit { get; set; } = null!;
    }
}

