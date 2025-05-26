using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatabaseAccessController;
using Newtonsoft.Json;
using SDP_EntityModels;
using System.Reflection.Metadata.Ecma335;

namespace SDP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserLoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("RegisterUser")]
        public int RegisterUser([FromBody] LoginRequest loginRequest)
        {
            try
            {
                String username = loginRequest.username;
                String password = loginRequest.password;

                dboUserLogin dboUserLogin = new dboUserLogin(_configuration["ConnectionStrings"]);
                int rowsUpdated = dboUserLogin.RegisterUser(username, password);
                return rowsUpdated;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("LoginUser")]
        public Boolean LoginUser([FromBody] LoginRequest loginRequest)
        {
            try
            {
                String username = loginRequest.username;
                String password = loginRequest.password;

                dboUserLogin dboUserLogin = new dboUserLogin(_configuration["ConnectionStrings"]);
                DataTable rowsUpdated = dboUserLogin.LoginUser(username, password);

                string jsonString = JsonConvert.SerializeObject(rowsUpdated);

                if (jsonString != "[]")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
