using DeliveryBookingProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Services
{
    public class ExecutiveManager : IRepo<DeliveryExecutive>
    {
        private DeliveryBookingContext _context;
        private ILogger<ExecutiveManager> _logger;

        public ExecutiveManager(DeliveryBookingContext context, ILogger<ExecutiveManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddInfo(DeliveryExecutive executive)
        {
            try
            {
                _context.Executives.Add(executive);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
            }
        }

        public bool DeleteInfo(DeliveryExecutive executive)
        {
            try
            {
                if (executive != null)
                {
                    _context.Executives.Remove(executive);
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

        public bool EditInfo(DeliveryExecutive executive)
        {
            try
            {
                if (executive != null)
                {
                    DeliveryExecutive executiveOldInfo = GetById(executive.ExecutiveId);
                    executiveOldInfo.ExecutiveName = executive.ExecutiveName;
                    executiveOldInfo.UserName = executive.UserName;
                    executiveOldInfo.Password = executive.Password;
                    executiveOldInfo.Age = executive.Age;
                    executiveOldInfo.Phone = executive.Phone;
                    executiveOldInfo.Address = executive.Address;
                    executiveOldInfo.City = executive.City;
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

        public IEnumerable<DeliveryExecutive> GetAllInfo()
        {
            try
            {
                if (_context.Executives.Count() == 0)
                    return null;
                return _context.Executives.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public DeliveryExecutive GetById(int id)
        {
            try
            {
                DeliveryExecutive executive = _context.Executives.FirstOrDefault(a => a.ExecutiveId == id);
                return executive;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
        public DeliveryExecutive GetByUserName(string UserName)
        {
            try
            {
                DeliveryExecutive executive = _context.Executives.SingleOrDefault(a => a.UserName == UserName);
                return executive;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}
