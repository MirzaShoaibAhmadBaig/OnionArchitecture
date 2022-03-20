using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Contract_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users : ControllerBase
    {
        private readonly IUser _user;

        public Users(IUser user)
        {
            this._user = user;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUser()
        {
            try
            {
                var responce = _user.GetAllRepo();
                return Ok(responce);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        [HttpGet]
        [Route("GetUserById")]
        public IActionResult  GetUserById(long Id)
        {
            var responce = _user.GetUserById(Id);
            return Ok (responce);
        }


        [HttpPost]
        [Route("AddNewUser")]
        public IActionResult AddNewUser(User user)
        {
            var respoce = _user.AddNewUser(user);
            return Ok(respoce);
        }

        [HttpDelete]
        [Route("RemoveUser")]
        public IActionResult RemoveUser(long Id)
        {
            var response = _user.RemoveUser(Id);
            return Ok(response);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            var responce = _user.UpdateUser(user);
            return Ok(responce);

        }

    }
}
