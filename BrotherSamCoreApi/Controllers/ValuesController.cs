using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrotherSamCoreApi.Src.DBClass;
using BrotherSamCoreApi.Src.Service;
using Microsoft.AspNetCore.Mvc;

namespace BrotherSamCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        ////begin 增加的接口
        //// GET api/<controller>/"张三"
        //[HttpGet("{userName}")]
        //public List<Brothersam_User> Get(string userName)
        //{
        //    UserService userService = new UserService();
        //    List<Brothersam_User> brotherSamUsers = userService.FindListByUserName(userName);
        //    return brotherSamUsers;
        //    //return $"这个是demo增加的接口，输入的是userName= : {userName}";
        //}
        ////end 增加的接口
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
