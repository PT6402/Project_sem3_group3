using Api.Interface.IRepo;
using Api.Repository;
using Lib.Dto.Coupon;
using Lib.Dto.User.Ctrl.Req;
using Lib.Dto.User.Repo;
using Lib.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _user;
        private readonly IHttpContextAccessor _accessor;

        public UserController(IUserRepository user, IHttpContextAccessor accessor)
        {
            _user = user;
            _accessor = accessor;
        }
        /*  [Route("update-profile")]
          [HttpPost]
          [Authorize]
          public async Task<ActionResult> UpdateUser(UserEditProfile request)
          {
              if (_accessor.HttpContext is not null)
              {
                  var findUserId = int.Parse(_accessor.HttpContext!.User.FindFirstValue(ClaimTypes.Sid));
                  var user = await _user.GetById(findUserId);
                  if (user is not null)
                  {
                      user.FirstName = request.FirstName;
                      user.LastName = request.LastName;
                      user.Phone = request.Phone;
                      await _userRepository.SaveUser();
                      return Ok(new UpdateResponse(user.FirstName, user.LastName, user.Phone));
                  }

              }
              return BadRequest("user not found");
          }*/


        [HttpGet]
        public async Task<IEnumerable<UserShow>> GetAll()
        {
            return await _user.GetUsers();
        }

        [HttpPut("update_profile")]
        public async Task<IActionResult> UpdateProfile(UpdateProfile model)
        {
            var result = await _user.UpdateProfile(model);

            if (result.Status)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("user_block")]
        public async Task<IActionResult> UserBlock(int userId)
        {
            var check = await _user.UserBlock(userId);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }

        [HttpPut("change_pass")]
        public async Task<IActionResult> ChangePass(UserChangePass model)
        {
            var check = await _user.UserChangePass(model);
            if (check.Status)
            {
                return Ok(check.Message);
            }
            return BadRequest(check.Message);
        }
    }
}
