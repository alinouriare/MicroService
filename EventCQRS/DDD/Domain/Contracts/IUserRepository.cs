﻿using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
  public  interface IUserRepository
    {
        Task Save(CustomIdentityUser user);

        Task<CustomIdentityUser> Get(int id);
    }
}
