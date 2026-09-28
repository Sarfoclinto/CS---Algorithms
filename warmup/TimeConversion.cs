namespace Algorithms.warmup
{
    internal class TimeConversion
    {
        public static string timeConversion(string s)
        {
            string zone = new([.. s.TakeLast(2)]);
            int hours = Convert.ToInt16(new string([.. s.Take(2)]));
            if(zone.Equals("am", StringComparison.CurrentCultureIgnoreCase))
            {
                if (hours == 12) hours -= 12;
            }
            else if(zone.Equals("pm", StringComparison.CurrentCultureIgnoreCase))
            {
                if (hours != 12) hours += 12;
            }
            return $"{hours.ToString().PadLeft(2, '0')}:{s.Substring(3, 5)}";
        }
    }
}
