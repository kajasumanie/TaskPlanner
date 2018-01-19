using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner
{
    class Program
    {




        public static List<DateTime> RecurringHolidays = new List<DateTime>();

        public static List<DateTime> Holidays = new List<DateTime>();
        List<DateTime> holidays = new List<DateTime>()
{
     new DateTime(2012, 01, 03),
     new DateTime(2012, 01, 26)
};


        //Holidays are stored in the format (mm-dd).
        //For simplicity each 2nd and 25 th days of the each month is considered as recurring holidays.
        // and 10 th and 18 th day of the each month also considered as holidays in addition to recurring holidays.
        public void SetRecurringHolidays(DateTime dateTime, double days)
        {
            dateTime = DateTime.Now;
          //  DateTime newDateTime = new DateTime();
            // int count1 = 0;
            if (dateTime.DayOfWeek != DayOfWeek.Saturday &&
         dateTime.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int i = 0; i < days; i++)
                {
                    dateTime = new DateTime();


                    TimeSpan NumberOfDays = new TimeSpan(2017, 0, 0, 0, 0);
                    dateTime = dateTime.Add(NumberOfDays);

                }
                Console.WriteLine(dateTime);
            }
        }

        public void Holiday(DateTime dateTime,double days)
        {
            dateTime = DateTime.Now;
            DateTime newDateTime = new DateTime();
            //   int count = 0;
            for (int i = 0; i < days; i++)
            {
                 dateTime = new DateTime();
               
              
                TimeSpan NumberOfDays = new TimeSpan(1, 0, 0, 0, 0);
                newDateTime = dateTime.Add(NumberOfDays);
                // count++;
            }
            Console.WriteLine(newDateTime);
        }

        /*for (int i = 0; i < 12; i++)
        {
            String month = (i + 1).ToString();
            String join = "-";
            String store1 = month + join + "2";
            String store2 = month + join + "25";


            DateTime disp1 = Convert.ToDateTime(store1);
            RecurringHolidays.Add(disp1);

            DateTime disp2 = Convert.ToDateTime(store2);
            RecurringHolidays.Add(disp2);*/





        /*  public void SetHolidays()
          {
              for (int i = 0; i < 12; i++)
              {
                  String month = (i + 1).ToString();
                  String join = "-";
                  String store1 = month + join + "10";
                  String store2 = month + join + "18";

                  DateTime disp1 = Convert.ToDateTime(store1);
                  Holidays.Add(disp1);

                  DateTime disp2 = Convert.ToDateTime(store2);
                  Holidays.Add(disp2);

              }

          }*/


        /*  static DateTime CalculateFutureDate(DateTime fromDate, double numberofWorkDays,
                                           List<DateTime> holidays)
          {
              var futureDate = fromDate;
              for (var i = 0; i < numberofWorkDays; i++)
              {
                  if (futureDate.DayOfWeek == DayOfWeek.Saturday
                     || futureDate.DayOfWeek == DayOfWeek.Sunday
                     || (Holidays != null && Holidays.Contains(futureDate)))
                  {
                      futureDate = futureDate.AddDays(1);
                      numberofWorkDays++;
                  }
                  else
                  {
                      futureDate = futureDate.AddDays(1);
                  }
              }
              while (futureDate.DayOfWeek == DayOfWeek.Saturday
                      || futureDate.DayOfWeek == DayOfWeek.Sunday
                      || (Holidays != null && Holidays.Contains(futureDate)))
              {
                  futureDate = futureDate.AddDays(1);
              }
              return futureDate;
          }*/


        static void Main(string[] args)
        {
           DateTime dateTime = DateTime.Now;
            var taskplanner = new Program();
            Console.WriteLine("Starting  of the Task of the Format yyyy/mm/dd");
            DateTime start = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Size of the Task");
            double size = Convert.ToDouble(Console.ReadLine());
            double days = size / 24;
            Console.WriteLine("Finishing Day");
            taskplanner. SetRecurringHolidays(dateTime,days);
            taskplanner.Holiday(dateTime,days);
           
        }

    }
}
















  