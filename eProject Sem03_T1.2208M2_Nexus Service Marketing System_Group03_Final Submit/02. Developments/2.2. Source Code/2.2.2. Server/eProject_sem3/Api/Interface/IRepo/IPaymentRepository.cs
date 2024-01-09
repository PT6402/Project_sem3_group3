using System;
using Lib.Dto;
using Lib.Dto.Payment;

namespace Api.Interface.IRepo
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<PaymentDto>> GetAll();
        Task<DtoResult<PaymentDto>> Create(PaymentDto model);
        Task<DtoResult<PaymentDto>> Update(PaymentDto model);
        Task<DtoResult<PaymentDto>> Delete(int id);
        Task<DtoResult<PaymentCheck>> checkPayment(string Phone);
        Task<DtoResult<List<PaymentListCheck>>> Daycheck(PayDateCheck dayInput);
    }
}

