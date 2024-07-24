using System;

namespace TestWeek4
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
            Dictionary<int, string> daysOfMonthD = new Dictionary<int, string>()
            {
                { 1, "יום אחד" },
                { 2, "שני ימים" },
                { 3, "שלשה ימים" },
                { 4, "ארבעה ימים" },
                { 5, "חמישה ימים" },
                { 6, "שישה ימים" },
                { 7, "שבעה ימים" },
                { 8, "שמונה ימים" },
                { 9, "תשעה ימים" },
                { 10, "עשרה ימים" },
                { 11, "אחד עשר יום" },
                { 12, "שנים עשר יום" },
                { 13, "שלשה עשר יום" },
                { 14, "ארבעה עשר ימים" },
                { 15, "חמישה עשר ימים" },
                { 16, "ששה עשר יום" },
                { 17, "שבעה עשר ימים" },
                { 18, "שמונה עשר ימים" },
                { 19, "תשעה עשר ימים" },
                { 20, "עשרים ימים" },
                { 21, "עשרים ואחד ימים" },
                { 22, "עשרים ושתיים ימים" },
                { 23, "עשרים ושלושה ימים" },
                { 24, "עשרים וארבעה ימים" },
                { 25, "עשרים וחמישה ימים" },
                { 26, "עשרים וששה ימים" },
                { 27, "עשרים ושבעה ימים" },
                { 28, "עשרים ושמונה ימים" },
                { 29, "עשרים ותשע ימים" },
                { 30, "שלשים ימים" }
            };
        }

        private void sendbutton_Click(object sender, EventArgs e, Dictionary<int, string> daysOfMonthD, Dictionary<string, string> hebrewMonthsD, Dictionary<int, string> hebrewYearsD)
        {
            string DayOfWeek = comboBox1.Text;
            string DayOfMonth = comboBox2.Text;
            string Month = comboBox3.Text;
            string Year = comboBox4.Text;
            string hebrewDayOfWeek = DayOfWeek;
            string hebrewDayOfMonth = daysOfMonthD[Convert.ToInt32(DayOfMonth)];
            string hebrewMonth = hebrewMonthsD[Month];
            string hebrewYear = hebrewYearsD[Convert.ToInt32(Year)];
            MessageBox.Show($"ב{hebrewDayOfWeek} {hebrewDayOfMonth} ל{hebrewMonth} {hebrewYear} לבריאת");
        }
    }
}
