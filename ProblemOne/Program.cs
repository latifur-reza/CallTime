using System;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string startTimeStr,endTimeStr;
            DateTime start, end, current, peakStart, peakEnd;
            double poisa = 0;
            Console.Write("Start time: ");
            startTimeStr = Console.ReadLine();
            Console.Write("End time: ");
            endTimeStr = Console.ReadLine();

            start = Convert.ToDateTime(startTimeStr);
            end = Convert.ToDateTime(endTimeStr);

            peakStart = Convert.ToDateTime("2019-08-31 09:00:00 am");
            peakEnd = Convert.ToDateTime("2019-08-31 10:59:59 pm");

            current = start;

            while (current < end)
            {
                int flag = 0;
                if (current.TimeOfDay >= peakStart.TimeOfDay && current.TimeOfDay <= peakEnd.TimeOfDay)
                {
                    flag = 1;
                }
                Console.Write(current);
                if(current.AddSeconds(20) < end)
                {
                    current = current.AddSeconds(20);
                    Console.Write( " +20 second ");
                    if (current.TimeOfDay >= peakStart.TimeOfDay && current.TimeOfDay <= peakEnd.TimeOfDay)
                    {
                        flag = 1;
                    }
                    Console.Write(current);
                    
                }
                else
                {
                    TimeSpan ts = end - current;
                    current = current.AddSeconds(ts.TotalSeconds);
                    if (current.TimeOfDay >= peakStart.TimeOfDay && current.TimeOfDay <= peakEnd.TimeOfDay)
                    {
                        flag = 1;
                    }
                    Console.Write(" + "+ts.TotalSeconds + " second ");
                    Console.Write(end);
                }

                if(flag == 1)
                {
                    poisa += 30;
                    Console.Write(" = 30");
                }
                else
                {
                    poisa += 20;
                    Console.Write(" = 20");
                }

                Console.WriteLine(" poisa");
                current = current.AddSeconds(1);
            }

            Console.WriteLine(poisa/100 + "taka");
        }
    }
}
