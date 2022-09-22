using GalatasarayShop.Business.Types;
using GalatasarayShop.Data.Dto;
using GalatasarayShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalatasarayShop.Business.Services
{
    public interface IUserService
    {
        ServiceMessage AddUser(UserEntity user);

        UserEntity Login(string email, string password);

        UserEntity GetUserById(int id);

        void UpdateUser(UserDto user);


    }
}
