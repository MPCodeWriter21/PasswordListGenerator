using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_maker.Classes
{
    public static class Convertor
    {
        // Converts a long integer(seconds) to a string like (x hours and y minutes) or (x minutes and y seconds)
        public static string GetReadableTime(long TimeSecs)
        {
            if (TimeSecs < 0)
                return "Unknown";
            long days = 0;
            long hours = 0;
            long minutes = 0;
            long seconds = TimeSecs;
            while (seconds > 60)
            {
                minutes++;
                seconds -= 60;
            }
            while (minutes > 60)
            {
                hours++;
                minutes -= 60;
            }
            while (hours > 24)
            {
                days++;
                hours -= 24;
            }
            string output = "";
            if (days != 0)
            {
                if (days == 1)
                {
                    if (hours != 0)
                    {
                        if (hours == 1)
                            output = "1 day and 1 hour";
                        else
                            output = $"1 day and {hours} hours";
                    }
                    else
                        output = "1 day";
                }
                else
                {
                    if (hours != 0)
                    {
                        if (hours == 1)
                            output = $"{days} days and 1 hour";
                        else
                            output = $"{days} days and {hours} hours";
                    }
                    else
                        output = $"{days} days";
                }
            }
            else if (hours != 0)
            {
                if (hours == 1)
                {
                    if (minutes != 0)
                    {
                        if (minutes == 1)
                            output = "1 hour and 1 minute";
                        else
                            output = $"1 hour and {minutes} minutes";
                    }
                    else
                        output = "1 hour";
                }
                else
                {
                    if (minutes != 0)
                    {
                        if (minutes == 1)
                            output = $"{hours} hours and 1 minute";
                        else
                            output = $"{hours} hours and {minutes} minutes";
                    }
                    else
                        output = $"{hours} hours";
                }
            }
            else if (minutes != 0)
            {
                if (minutes == 1)
                {
                    if (seconds != 0)
                    {
                        if (seconds == 1)
                            output = "1 minute and 1 second";
                        else
                            output = $"1 minute and {seconds} seconds";
                    }
                    else
                        output = "1 minute";
                }
                else
                {
                    if (seconds != 0)
                    {
                        if (seconds == 1)
                            output = $"{minutes} minutes and 1 second";
                        else
                            output = $"{minutes} minutes and {seconds} seconds";
                    }
                    else
                        output = $"{minutes} minutes";
                }
            }
            else
            {
                if (seconds < 2)
                    output = $"{seconds} second";
                else
                    output = $"{seconds} seconds";
            }

            return output;
        }
    }
}
