using DeliveryBookingProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Services
{
    public class CustomerManager : IRepo<Customer>
    {
        private DeliveryBookingContext _context;
        private ILogger<CustomerManager> _logger;

        public CustomerManager(DeliveryBookingContext context, ILogger<CustomerManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddInfo(Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
            }
        }

        public bool DeleteInfo(Customer customer)
        {
            try
            {
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return false;
        }

        public bool EditInfo(Customer customer)
        {
            try
            {
                if (customer != null)
                {
                    Customer customerOldInfo = GetById(customer.CustomerId);
                    customerOldInfo.CustomerName = customer.CustomerName;
                    customerOldInfo.UserName = customer.UserName;
                    customerOldInfo.Password = customer.Password;
                    customerOldInfo.Age = customer.Age;
                    customerOldInfo.Phone = customer.Phone;
                    customerOldInfo.Address = customer.Address;
                    customerOldInfo.City = customer.City;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
            }
            return false;
        }

        public IEnumerable<Customer> GetAllInfo()
        {
            try
            {
                if (_context.Customers.Count() == 0)
                    return null;
                return _context.Customers.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public Customer GetById(int id)
        {
            try
            {
                Customer customer = _context.Customers.FirstOrDefault(a => a.CustomerId == id);
                return customer;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public Customer GetByUserName(string UserName)
        {
            try
            {
                Customer customer = _context.Customers.SingleOrDefault(a => a.UserName == UserName);
                return customer;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}
