﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobHunter.BusinessEntities;
using JobHunter.BusinessServices;

namespace JobHunter.API.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserServices _userServices;

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize user service instance
        /// </summary>
        public UserController()
        {
            _userServices = new UserServices();
        }

        #endregion

        // GET api/user
        public HttpResponseMessage Get()
        {
            var users = _userServices.GetAllUsers();
            if (users != null)
            {
                var userEntities = users as List<UserEntity> ?? users.ToList();
                if (userEntities.Any())
                    return Request.CreateResponse(HttpStatusCode.OK, userEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Users not found");
        }

        // GET api/user/5
        public HttpResponseMessage Get(int id)
        {
            var user = _userServices.GetUserById(id);
            if (user != null)
                return Request.CreateResponse(HttpStatusCode.OK, user);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No user found for this id");
        }

        // POST api/user
        public int Post([FromBody] UserEntity userEntity)
        {
            return _userServices.CreateUser(userEntity);
        }

        // PUT api/user/5
        public bool Put(int id, [FromBody]UserEntity userEntity)
        {
            if (id > 0)
            {
                return _userServices.UpdateUser(id, userEntity);
            }
            return false;
        }

        // DELETE api/user/5
        public bool Delete(int id)
        {
            if (id > 0)
                return _userServices.DeleteUser(id);
            return false;
        }
    }
}
