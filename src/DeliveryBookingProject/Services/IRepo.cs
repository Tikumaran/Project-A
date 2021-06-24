using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Services
{
    public interface IRepo<T>
    {
        bool AddInfo(T t);
        T GetById(int id);
        IEnumerable<T> GetAllInfo();
        bool EditInfo(T t);
        bool DeleteInfo(T t);
        T GetByUserName(string UserName);
    }
}
