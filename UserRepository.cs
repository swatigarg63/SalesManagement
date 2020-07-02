using Microsoft.EntityFrameworkCore;
using RestaurantOnlineAPI.Model.Data;
using RestaurantOnlineAPI.Model.Models;
using RestaurantOnlineAPI.Service.Abstract;
using RestaurantOnlineAPI.Service.Context;
using RestaurantOnlineAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace RestaurantOnlineAPI.Service.Repository
{
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        #region Private instance
        private readonly ApplicationDatabaseContext context;
        #endregion
        #region constructor
        public UserRepository(ApplicationDatabaseContext context) : base(context) 
        {
            this.context = context;
        }


        #endregion
        #region Methods
        public AppUser GetUserDetail(string email)
        {
            return context.Users.AsNoTracking().FirstOrDefault(x => x.Email.Trim().ToLower() == email.Trim().ToLower());
        }
        #endregion
    }



}
