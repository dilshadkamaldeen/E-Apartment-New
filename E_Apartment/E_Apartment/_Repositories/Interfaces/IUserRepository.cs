using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IUserRepository
    {
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(int id);
        IEnumerable<UserModel> GetAll();
        IEnumerable<UserModel> GetByValue(string value); //search by name or location
    }
}
