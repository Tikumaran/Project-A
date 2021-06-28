using DeliveryBookingProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Services
{
    public class BookingManager : IRepo<DeliveryBooking>
    {
        private DeliveryBookingContext _context;
        private ILogger<BookingManager> _logger;

        public BookingManager(DeliveryBookingContext context, ILogger<BookingManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool AddInfo(DeliveryBooking booking)
        {
            try
            {
                _context.DeliveryBookings.Add(booking);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return false;
            }
        }

        public bool DeleteInfo(DeliveryBooking booking)
        {
            try
            {
                if (booking != null)
                {
                    _context.DeliveryBookings.Remove(booking);
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
                _logger.LogError(e.Message);
                return false;
            }
        }

        public bool EditInfo(DeliveryBooking booking)
        {
            try
            {
                if (booking != null)
                {
                    _context.DeliveryBookings.Update(booking);
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
                _logger.LogError(e.Message);
                return false;
            }
        }

        public IEnumerable<DeliveryBooking> GetAllInfo()
        {
            try
            {
                if (_context.DeliveryBookings.Count() == 0)
                {
                    return null;
                }
                else
                {
                    return _context.DeliveryBookings.ToList();
                    //List<DeliveryBooking> booking = (List<DeliveryBooking>)_context.DeliveryBookings.Join(_context.Customers, b => b.CustomerId, c => c.CustomerId, (b, c) => new { b, c })
                    //                                                .Join(_context.Executives, p => p.b.ExecutiveId, e => e.ExecutiveId, (p, e) => new { p, e });
                    //return booking;
                }
                

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        public DeliveryBooking GetById(int id)
        {
            try
            {
                DeliveryBooking booking = _context.DeliveryBookings.FirstOrDefault(a => a.OrderId == id);
                return booking;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        public DeliveryBooking GetByUserName(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
