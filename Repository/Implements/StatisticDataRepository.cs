using Microsoft.EntityFrameworkCore;
using Repository.Database.Default;
using Repository.Database.Default.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class StatisticDataRepository
    {
        public async static Task InitDataGoiYSlotChamCong(int salonId = 2, int bookingCount = 10)
        {
            using (var db = new Solution30ShineContext())
            {
                var bookHourSubs = await db.BookHourSub.Where(m => m.SalonId == salonId && m.Publish == true && m.IsDelete == false).ToListAsync();

                var bookHourSecondSubHours = await db.BookHour2ndSub.Where(m => m.SalonId == salonId && m.Publish == true && m.IsDelete == false).ToListAsync();

                var dates = new List<DateTime>()
                {
                    new DateTime(2021,4,21),
                    new DateTime(2021,4,14),
                    new DateTime(2021,4,7),
                    new DateTime(2021,3,31)
                };
                foreach (var date in dates)
                {
                    foreach (var bookHourSub in bookHourSubs)
                    {
                        for (int i = 0; i < bookingCount; i++)
                        {
                            var booking = new Booking()
                            {
                                CustomerPhone = "0123123123",
                                DatedBook = date,
                                IsDelete = 0,
                                SalonId = salonId,
                                SubHour = bookHourSub.SubHourId
                            };
                            db.Booking.Add(booking);
                            db.SaveChanges();
                            var billService = new BillService()
                            {
                                IsDelete = 0,
                                BookingId = booking.Id,
                                SalonId = salonId,
                                Pending = 0
                            };
                            db.BillService.Add(billService);
                            db.SaveChanges();

                            var data = db.BookingSlotTotal.FirstOrDefault(m => m.IsDelete == false && m.WorkDate == date && m.SubHourId == bookHourSub.SubHourId && m.SalonId == salonId && m.GroupId == 0);

                            if (data != null)
                            {
                                data.Total = 5;
                            }
                            else
                            {
                                var mo = new BookingSlotTotal()
                                {
                                    Total = 5,
                                    GroupId = 0,
                                    WorkDate = date,
                                    HourFrame = TimeSpan.FromDays(1),
                                    SalonId = salonId,
                                    HourId = bookHourSub.HourId,
                                    IsDelete = false,
                                    StaffId = 0,
                                    SecondSubHourId = 0,
                                    SubHourId = bookHourSub.SubHourId,
                                };
                                db.BookingSlotTotal.Add(mo);
                            }
                            db.SaveChanges();
                        }
                    }

                    foreach (var bookHourSecondSubHour in bookHourSecondSubHours)
                    {
                        for (int i = 0; i < bookingCount; i++)
                        {
                            var booking = new Booking()
                            {
                                CustomerPhone = "0123123123",
                                DatedBook = date,
                                IsDelete = 0,
                                SalonId = 2,
                                SecondSubHour = bookHourSecondSubHour.SecondSubHourId
                            };
                            db.Booking.Add(booking);
                            db.SaveChanges();
                            var billService = new BillService()
                            {
                                IsDelete = 0,
                                BookingId = booking.Id,
                                SalonId = 2,
                                Pending = 0
                            };
                            db.BillService.Add(billService);
                            db.SaveChanges();

                            var data = db.BookingSlotTotal.FirstOrDefault(m => m.IsDelete == false && m.WorkDate == date && m.SubHourId == bookHourSecondSubHour.SecondSubHourId && m.SalonId == salonId && m.GroupId == 0);

                            if (data != null)
                            {
                                data.Total = 5;
                            }
                            else
                            {
                                var mo = new BookingSlotTotal()
                                {
                                    Total = 5,
                                    GroupId = 0,
                                    WorkDate = date,
                                    HourFrame = TimeSpan.FromDays(1),
                                    SalonId = salonId,
                                    HourId = bookHourSecondSubHour.HourId,
                                    IsDelete = false,
                                    StaffId = 0,
                                    SecondSubHourId = 0,
                                    SubHourId = bookHourSecondSubHour.SecondSubHourId,
                                };
                                db.BookingSlotTotal.Add(mo);
                            }
                            db.SaveChanges();
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------
            }
        }
    }
}
