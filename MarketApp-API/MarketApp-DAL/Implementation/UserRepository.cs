using MarketApp_DAL.Data;
using MarketApp_DAL.Repository;
using MarketApp_DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_DAL.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public void CreateRole(string userId)
        {
           var userRole = _dbContext.Roles.FirstOrDefault(x => x.Name == "User").Id;
             _dbContext.UserRoles.Add(new IdentityUserRole<string>
                {
                    RoleId = userRole,
                    UserId = userId
             });
            _dbContext.SaveChanges();
        }
    }
}
