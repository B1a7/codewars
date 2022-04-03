// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

// HH = hours, padded to 2 digits, range: 00 - 99
// MM = minutes, padded to 2 digits, range: 00 - 59
// SS = seconds, padded to 2 digits, range: 00 - 59
// The maximum time never exceeds 359999 (99:59:59)

// You can find some examples in the test fixtures.
// public static class TimeFormat



{
    public static string GetReadableTime(int seconds)
    {
            int hours = seconds / 3600;
            int minutes = (seconds%3600) / 60;
            int secondss = ((seconds%3600) %60);
            string time = $"{hours:d2}:{minutes:d2}:{secondss:d2}";
            return time;
      // var t = TimeSpan.FromSeconds(seconds);
            // return $"{(int) t.TotalHours:00}:{t.Minutes:00}:{t.Seconds:00}";
    }
}