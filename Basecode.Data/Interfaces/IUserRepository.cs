﻿using Basecode.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Basecode.Data.Interfaces
{
    public interface IUserRepository
    {
        User FindByUsername(string username);
        User FindById(string id);
        IdentityUser FindUser(string UserName);
        IEnumerable<User> FindAll();
        bool Create(User user);
        bool Update(User user);
        void Delete(User user);
        Task<IdentityResult> RegisterUser(string username, string password, string firstName, string lastName, string email, string role);
        Task<IdentityResult> CreateRole(string roleName);
        Task<IdentityUser> FindUser(string userName, string password);
        Task<IdentityUser> FindUserAsync(string userName, string password);
    }
}
