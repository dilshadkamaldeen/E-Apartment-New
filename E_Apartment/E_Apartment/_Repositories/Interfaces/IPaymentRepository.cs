using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IPaymentRepository
    {
        void Add(PaymentModel paymentModel);
        void Update(PaymentModel paymentModel);
        void Delete(int id);
        IEnumerable<PaymentModel> GetAll();
        IEnumerable<PaymentModel> GetByValue(string value); //search by name or location
    }
}
