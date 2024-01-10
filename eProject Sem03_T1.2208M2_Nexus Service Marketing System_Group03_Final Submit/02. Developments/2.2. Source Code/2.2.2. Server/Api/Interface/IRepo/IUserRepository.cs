using Lib.Dto;
using Lib.Dto.User.Ctrl.Req;
using Lib.Dto.User.Repo;
using Lib.Entities;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Api.Interface.IRepo
{
    public interface IUserRepository
    {
        Task<bool> SaveUser();
        Task<User>? GetUserByRefreshToken(string refreshToken);
        Task<UserDto?> GetByPhone(string phone);
        Task<UserDto?> GetBy16(string account);
        Task<UserDto?> GetByEmail(string email);
        Task<UserDto?> GetById(int userId);
        Task<DtoResult<UserDto>> Create(UserDto model);
        Task<DtoResult<UserDto>> CheckUser(UserDto model);
        Task<bool> UpdateToken(TokenDto model);
        Task<bool> SendMailResetPassword(string toEmail, int UserId);
        Task<DtoResult<MessageResource>> SendSMSResetPassword(string toPhone, int UserId);

        Task<DtoResult<UserDto>> ResetPassword(int UserId, string Password);

        Task<DtoResult<MessageResource>> VerifyPhone(string Phone);
        Task<List<UserShow>> GetUsers();
        Task<User> GetUserById(int user);
        Task<DtoResult<UpdateProfile>> UpdateProfile(UpdateProfile modal);
        Task<DtoResult<UserShow>> UserBlock(int userId);
        Task<DtoResult<UserChangePass>> UserChangePass(UserChangePass model);
    }
}
