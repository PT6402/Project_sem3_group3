using Api.Data_helper;
using Api.Interface.IRepo;
using Api.Interface.IService;
using Api.Service.Mail;
using Api.Service.SMS;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Coupon;
using Lib.Dto.User.Ctrl.Req;
using Lib.Dto.User.Repo;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;
using Twilio.Rest.Api.V2010.Account;

namespace Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMail _mail;
        private readonly ISMS _sms;
        private readonly IMapper _mapper;
        private readonly IPassword _password;
        private readonly IDateTimeProvider _time;

        public UserRepository(DatabaseContext db, IMail mail, IMapper mapper, IPassword password, IDateTimeProvider time, ISMS sms)
        {
            _db = db;
            _mail = mail;
            _mapper = mapper;
            _password = password;
            _time = time;
            _sms = sms;
        }
        public async Task<User> GetUserById(int userId)
        {
            var user = await _db.Users!.FirstOrDefaultAsync(x => x.Id == userId);
            if (user is not null)
            {
                return user;
            }
            return null!;
        }
        public async Task<UserDto?> GetByPhone(string phone)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Phone == phone);
                if (user is null)
                {
                    return null!;
                }
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null!;
            }
        }

        public async Task<UserDto?> GetById(int userId)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == userId);
                if (user is null)
                {
                    return null!;
                }
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null!;
            }
        }

        public async Task<UserDto?> GetByEmail(string email)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Email == email);
                if (user is null)
                {
                    return null!;
                }
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null!;
            }
        }

        public async Task<DtoResult<UserDto>> Create(UserDto model)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Phone == model.Phone);
                if (user is not null)
                {
                    return new()
                    {
                        Status = false,
                        Message = "Phone is exist"
                    };
                }
                var hash = _password.CreatePassword(model.Password);
                User newUser = new()
                {
                    FullName = model.FullName,
                    Phone = model.Phone,
                    PasswordHash = hash.PasswordHash,
                    PasswordSalt = hash.PasswordSalt,
                    Status = "Active",
                };
                _db.Users.Add(newUser);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create User successfully!",
                    Model = _mapper.Map<UserDto>(newUser)
                };
            }
            catch (Exception e)
            {
                return new()
                {
                    Status = false,
                    Message = e.Message,
                };
            }
        }

        public async Task<DtoResult<UserDto>> CheckUser(UserDto model)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Phone == model.Phone);
                if (user is null)
                {
                    return new()
                    {
                        Status = false,
                        Message = "User is not found"
                    };
                }

                var checkPass = _password.VerifyPassword(model.Password, user);
                if (!checkPass)
                {
                    return new()
                    {
                        Status = false,
                        Message = "Password Invalid"
                    };
                }

                return new()
                {
                    Status = true,
                    Model = _mapper.Map<UserDto>(user)
                };
            }
            catch (Exception e)
            {
                return new()
                {
                    Status = false,
                    Message = e.Message
                };
            }
        }

        public async Task<bool> UpdateToken(TokenDto model)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == model.UserId);
                if (user is null)
                {
                    return false;
                }
                user.RefreshToken = model.RefreshToken;
                user.TokenCreated = model.TokenCreated;
                user.TokenExpires = model.TokenExpires;
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SendMailResetPassword(string toEmail, int UserId)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == UserId);
            if (user is null)
            {
                return false;
            }

            //
            Random r = new();
            string random_digit = r.Next(0, 1000000).ToString("000000");

            //
            user.PasswordReset = random_digit;
            user.ResetExpires = _time.UtcNow.AddDays(1);
            user.MethodReset = 0;
            await _db.SaveChangesAsync();

            //
            TemplateEmail template = new()
            {
                ProductName = "Nexus",
                UserName = user.FullName,
                CodeReset = random_digit
            };
            string body = template.TemplateEmailReset();
            EmailRequest sendMail = new()
            {
                To = toEmail,
                Subject = "email to reset password",
                Body = body
            };
            return _mail.SendEmail(sendMail);
        }
        public async Task<DtoResult<MessageResource>> SendSMSResetPassword(string toPhone, int UserId)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == UserId);
            if (user is null)
            {
                return new()
                {
                    Status = false,
                    Message = "user not found"
                };
            }

            //
            Random r = new();
            string random_digit = r.Next(0, 1000000).ToString("000000");

            //
            user.PasswordReset = random_digit;
            user.ResetExpires = _time.UtcNow.AddDays(1);
            user.MethodReset = 1;
            await _db.SaveChangesAsync();

            //


            SMSRequest sendSMS = new()
            {
                To = toPhone,
                Body = random_digit
            };

            var result = await _sms.SendSMS(sendSMS);
            return result;
        }

        public async Task<DtoResult<UserDto>> ResetPassword(int UserId, string Password)
        {
            try
            {
                var user = _db.Users.FirstOrDefault(x => x.Id == UserId);
                if (user is null)
                {
                    return new()
                    {
                        Status = false,
                        Message = "User not found",
                    };
                }

                var hash = _password.CreatePassword(Password);
                //[pass]
                user.PasswordHash = hash.PasswordHash;
                user.PasswordSalt = hash.PasswordSalt;

                //[reset-pass]
                user.ResetExpires = null;
                user.PasswordReset = string.Empty;
                user.MethodReset = null;
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "change password success",
                    Model = _mapper.Map<UserDto>(user)
                };
            }
            catch (Exception e)
            {
                return new()
                {
                    Status = false,
                    Message = e.Message
                };
            }
        }
        public async Task<DtoResult<MessageResource>> VerifyPhone(string Phone)
        {
            try
            {

                Random r = new();
                string random_digit = r.Next(0, 1000000).ToString("000000");

                SMSRequest sendSMS = new()
                {
                    To = Phone,
                    Body = random_digit
                };

                var result = await _sms.SendSMS(sendSMS);
                if (!result.Status)
                {
                    return result;
                }
                else
                {

                    return new()
                    {
                        Status = true,
                        Message = random_digit
                    };
                }

            }
            catch (Exception e)
            {
                return new()
                {
                    Status = false,
                    Message = e.Message
                };
            }
        }

        public async Task<List<UserShow>> GetUsers()
        {
            var users = await _db.Users.Where(u => u.Role == "user").ToListAsync();
            var res = new List<UserShow>();
            foreach (var u in users)
            {
                res.Add(_mapper.Map<UserShow>(u));
            }
            return res;

        }
        public async Task<User>? GetUserByRefreshToken(string refreshToken)
        {
            var user = await _db.Users!.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
            if (user is not null)
            {
                return user;
            }
            return null!;
        }

        public async Task<bool> SaveUser()
        {
            try
            {
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<UserDto?> GetBy16(string account)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(x => x.TP_contract_Id == account);
                if (user is null)
                {
                    return null!;
                }
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null!;
            }
        }

        public async Task<DtoResult<UpdateProfile>> UpdateProfile(UpdateProfile modal)
        {
            try
            {
                var check = await _db.Users.FirstOrDefaultAsync(x => x.Id == modal.User_Id);

                if (check != null)
                {
                    check.FullName = modal.Fullname ?? check.FullName;
                    check.Email = modal.Email ?? check.Email;

                    await _db.SaveChangesAsync();
                    UpdateProfile hoso = new UpdateProfile()
                    {
                        Fullname = check.FullName,
                        Email = check.Email
                    };
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully",
                        Model = hoso
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "Update fail"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DtoResult<UserShow>> UserBlock(int userId)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
                if (user != null)
                {
                    user.Status = "Block";
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Block successfully"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "fail"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DtoResult<UserChangePass>> UserChangePass(UserChangePass model)
        {
            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == model.User_Id);
                if (user != null)
                {
                    var check = _password.VerifyPassword(model.Current_pass, user);
                    if (!check)
                    {
                        return new()
                        {
                            Status = false,
                            Message = "Password Invalid"
                        };
                    }

                    if(model.New_pass != model.Confirm_pass)
                    {
                        return new()
                        {
                            Status = false,
                            Message = "new pass and confirm pass not matching"
                        };
                    }

                    if (model.New_pass.Length < 6 || !model.New_pass.Any(char.IsLetter) || !model.New_pass.Any(char.IsDigit))
                    {
                        return new()
                        {
                            Status = false,
                            Message = "New password must be at least 6 characters long and contain at least one letter and one digit."
                        };
                    }

                    var hash = _password.CreatePassword(model.New_pass);
                    user.PasswordHash = hash.PasswordHash;
                    user.PasswordSalt = hash.PasswordSalt;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Change PassWord Successfully!"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "User not found"
                };
            }
            catch(Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }
    }
}
