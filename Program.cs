using System;

namespace TimeDiffUsingStruct
{
    class Program
    {
        struct timeDiff
        {
            public TimeSpan time; 
            
            public timeDiff(DateTime indiaTime, DateTime sgTime)
            {          
                //indiaTime = DateTime.Parse("11:00");
                //sgTime =  DateTime.Parse("16:00");
                time = indiaTime - sgTime;
            }
        }

        static void timeDiff2()
        {
           /* DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2021, 05, 22, 06, 18, 55);
            TimeSpan t = dt1 - dt2;
            Console.WriteLine("days: " + t.Days);
            Console.WriteLine("hours: " + t.Hours);
            Console.WriteLine("minutes: " + t.Minutes);*/

            DateTime time, time1;
            Console.WriteLine("1st time hour:");
            int hr1 = Int32.Parse(Console.ReadLine());
            time = DateTime.MinValue;
            time = time + new TimeSpan(hr1, 0, 0);
            Console.WriteLine("2nd time hour:");
            int hr2 = Int32.Parse(Console.ReadLine());
            time1 = DateTime.MinValue;
            time1 = time1 + new TimeSpan(hr2, 0, 0);
            TimeSpan result = (time1 - time);
            Console.WriteLine("Diff: " + result);
        }
        static void Main(string[] args)
        {
            //timeDiff timedif = new timeDiff(sgTime:DateTime.Parse("16:00"), indiaTime:DateTime.Parse("11:00"));
            //Console.WriteLine("The difference in time between india and singapore is : " + timedif.time);

            timeDiff2();
        }
    }
}
