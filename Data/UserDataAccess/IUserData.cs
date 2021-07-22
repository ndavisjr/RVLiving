using RVLiving.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RVLiving.Data
{
    public interface IUserData
    {
        Task<List<UserModel>> GetUsers();
        Task InsertUser(UserModel user);
    }
}