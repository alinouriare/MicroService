using Domain.Contracts;
using Domain.Models.Users;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
public    class UserRepository: IUserRepository
    {
        private readonly APPContext context;

        public UserRepository(APPContext context)
        {
            this.context = context;
        }

        public async Task<CustomIdentityUser> Get(int id)
        {
            var user = await context.CustomIdentityUsers.FirstOrDefaultAsync(c => c.Id == id);
            return user;

        }

        public async Task Save(CustomIdentityUser  user)
        {
            context.CustomIdentityUsers.Update(user);
           await context.SaveEntitiesAsync();
        }
    }
}
