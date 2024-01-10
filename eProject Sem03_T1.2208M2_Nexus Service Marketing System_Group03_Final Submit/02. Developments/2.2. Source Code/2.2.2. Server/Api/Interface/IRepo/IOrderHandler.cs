using System;
using Lib.Dto.OrderHandler;

namespace Api.Interface.IRepo
{
	public interface IOrderHandler
	{
        Task<IEnumerable<OrderHandlerDto>> GetOrderHandlerDtos();

    }
}

