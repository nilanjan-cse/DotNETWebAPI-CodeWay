using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_CodeWay.Models;
using WebAPI_CodeWay.Repo;

namespace WebAPI_CodeWay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IRepo repo;
        public UserInfoController(IRepo repo)
        {
            this.repo = repo;
        }


        [HttpGet]
        [Route("getusers")]
        public ActionResult<IEnumerable<UserInfo>> Get()
        {
            return Ok(repo.GetUsers());
        }
        [HttpPut]
        [Route("adduser")]
        public ActionResult<string> Add([FromBody] UserInfo userInfo)
        {
            int res = repo.AddUser(userInfo);
            if (res == 0)
            { return Ok("success"); }
            return BadRequest(res);
        }
        [HttpPost]
        [Route("updateuser")]
        public ActionResult<UserInfo> Update([FromBody] UserInfo userInfo)
        {
            int res = repo.UpdateUser(userInfo);
            if (res == 0)
            { return Ok("success"); }
            return BadRequest(res);

        }
        [HttpDelete]
        [Route("deleteuser")]
        public ActionResult<UserInfo> Delete([FromBody] UserInfo userInfo)
        {
            int res = repo.DeleteUser(userInfo);
            if (res == 0)
            { return Ok("success"); }
            return BadRequest(res);

        }
    }
}
