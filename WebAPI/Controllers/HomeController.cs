using Business.Abstract;
using Business.Concrete;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private IGenericService<User> _userService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _userService = new UserManager();
        }

        [Route("GetAllUsers")]
        [HttpGet]
        public JsonResult GetAllUsers()
        {
            return new JsonResult(new { StatusCode = _userService.GetAll().Status, _userService.GetAll().Data });
        }
    }
}