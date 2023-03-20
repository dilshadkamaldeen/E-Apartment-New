using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IWaitingListRepository
    {
        void Add(WaitingListModel waitingListModel);
        void Update(WaitingListModel waitingListModel);
        void Delete(int id);
        IEnumerable<WaitingListModel> GetAll();
        IEnumerable<WaitingListModel> GetByValue(string value); //search by name or location
    }
}
