using MarketApp_DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_DAL.Repository
{
    public interface IUserRepository
    {
        void CreateRole(string userId);
        //check if username is occupied
    }
}
