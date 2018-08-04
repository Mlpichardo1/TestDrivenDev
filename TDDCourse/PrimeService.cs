using System;

namespace TDDCourse
{
    public class Bill
    {
        public DateTime CheckDate(DateTime dueDate)
        {
            var checkHoliday = new HolidayService();
            var paymentDate = dueDate;

            while(paymentDate.DayOfWeek == DayOfWeek.Saturday || 
                  paymentDate.DayOfWeek == DayOfWeek.Sunday ||
                  checkHoliday.isHoliday(paymentDate))
                  {
                      paymentDate = paymentDate.AddDays(1);
                  }
            // if(dueDate.DayOfWeek == DayOfWeek.Saturday)
            //     return dueDate.AddDays(2);
            // if(dueDate.DayOfWeek == DayOfWeek.Sunday)
            //     return dueDate.AddDays(1);

           return paymentDate; 
        }

        public class HolidayService
        {
        public bool isHoliday(DateTime dueDate)
        {
            var holidays = new List<DateTime>();
            holidays.Add(new DateTime(2018,12,25));
            // var output = obj.CheckDate(input);
            if(holidays.Contains)
        }
        }
    }
}
