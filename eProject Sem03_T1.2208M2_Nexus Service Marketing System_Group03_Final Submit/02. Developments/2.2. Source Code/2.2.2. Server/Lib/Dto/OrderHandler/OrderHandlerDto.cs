using System;
namespace Lib.Dto.OrderHandler
{
	public class OrderHandlerDto
	{
        public int Id { get; set; }
        public int Address_store_Id { get; set; }
        public string Order_Id { get; set; } = null!;
        public int? Employee_Id { get; set; }
        public bool StatusHandle { get; set; }
    }
}

