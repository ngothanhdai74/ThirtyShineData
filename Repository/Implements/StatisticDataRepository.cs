using Repository.Database.Default;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implements
{
    public class StatisticDataRepository
    {
        public async Task CreateBookingAndCompleteBill(int salonId, int bookingCount)
        {
            using (var db = new Solution30ShineContext())
            {
                //var aa = DateTime.Today.DayOfWeek;
                //db.TimekeepingSuggestionStaticData



            }
        }
    }
}
