using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRunCounter
{
    public class Run
    {
        public int RunNumber { get; set; }
        public int SessionRunNumber { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime Started { get; set; }
        public DateTime Ended { get; set; }
        public string Notes { get; set; }

        public TimeSpan DurationRounded
        {
            get
            {
                var roundedSec = (int)Math.Round((double)Duration.Milliseconds / 1000.0);
                var rounded = new TimeSpan(
                    Duration.Hours, 
                    Duration.Minutes, 
                    Duration.Seconds + roundedSec);
                return rounded;
            }
        }

        public string DurationStr
        {
            get
            {
                return FormatDurationStr(Duration);
            }
        }

        public static string FormatDurationStr(TimeSpan duration)
        {
            var min = duration.Minutes;
            var sec = duration.Seconds;
            var tenthSec = (int)Math.Floor((double)duration.Milliseconds / 100);

            var secStr = sec.ToString();
            if (min > 0)
            {
                secStr = sec < 10 ? "0" + sec : sec.ToString();
                return String.Format("{0}:{1}.{2}",
                    min,
                    secStr,
                    tenthSec);
            }

            return String.Format("{0}.{1}",
                secStr,
                tenthSec);
        }
    }
}
