namespace TestWeek4.Model
{
    internal class Dates
    {
        public string DayOfWeek { get; set; }
        public string DayOfMonth { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Result { get; set; }
        public Dates(string dayOfWeek, string dayOfMonth, string month, string year, string result)
        {
            DayOfWeek = dayOfWeek;
            DayOfMonth = dayOfMonth;
            Month = month;
            Year = year;
            Result = null;
        }
    }
}

