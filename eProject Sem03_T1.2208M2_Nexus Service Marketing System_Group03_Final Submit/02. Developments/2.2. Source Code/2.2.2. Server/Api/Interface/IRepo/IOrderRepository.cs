using System;
using System.Threading.Tasks;
using Lib.Dto;
using Lib.Dto.OrderHandler;
using Lib.Dto.Orders;

namespace Api.Interface.IRepo
{
    public interface IOrderRepository
    {
        Task<DtoResult<OrderDto>> Create(OrderDto orderDto);
        Task<IEnumerable<OrderRes>> GetAll();
        Task<DtoResult<OrderRes>> Edit(OrderRes orderDto);
        Task<DtoResult<OrderDto>> Delete(string id);
        Task<DtoResult<List<OrderSummary>>> summary(int userID);

        Task<DtoResult<OrderRes>> StopOrder(string OrderId);
        Task<IEnumerable<OrderSummary>> GetOrderByStatusFeed();
        Task<bool> UpdateOrderToFinish(string OrderId);
    }
}

