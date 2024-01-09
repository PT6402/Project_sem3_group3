using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto.OrderHandler;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
	public class OrderHandlerRepository:IOrderHandler
	{
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public OrderHandlerRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderHandlerDto>> GetOrderHandlerDtos()
        {
            var ol = await _db.Order_handler.ToListAsync();
            var rl = new List<OrderHandlerDto>();
            foreach (var o in ol)
            {
                rl.Add(_mapper.Map<OrderHandlerDto>(o));
            }
            return rl;
        }
    }
}

