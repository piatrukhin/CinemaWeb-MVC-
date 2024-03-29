﻿using CinemaWeb.Domain.Entity;
using CinemaWeb.Domain.Response;
using CinemaWeb.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWeb.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> CreateUser(UserViewModel model);
        BaseResponse<Dictionary<int,string>> GetRoles();
        Task<IBaseResponse<bool>> DeleteUsers(long id);
        Task<IBaseResponse<IEnumerable<UserViewModel>>> GetUsers();
    }
}
