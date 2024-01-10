using System;
using Lib.Dto;
using Lib.Dto.EmployeeDto;
using Lib.Dto.FeedbackSend;
using Lib.Dto.Product.Ctrl;
using Lib.Entities;

namespace Api.Interface.IRepo
{
    public interface IEmployee
    {
        Task<string> CreateEmp(EmployeeDto model);
        Task<IEnumerable<EmployeeDto>> GetEmployees();
        Task<DtoResult<EmployeeDto>> Delete(int id);
        Task<DtoResult<EmployeeDto>> Edit(EmployeeDto model);
        Task<DtoResult<List<ProductDto>>> CheckProduct(checkProduct check);
        Task<bool> StaffEditStatus(string Order_Id);
        Task<bool> TechEditStatus(string Order_Id);
        Task<DtoResult<Feedback>> Sendfeed(SendDto send);
        Task<IEnumerable<Feedback>> SeeFeed();
        Task<DtoResult<Feedback>> Replyfeed(ReplyDto reply);
        Task<bool> StaffStatusPayment(string Order_Id);
    }
}

