using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_4
{
    class MyDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateTime myDate { get; set; }

        public MyDate(int day,int month,int year)
        {
            Day= day;
            Month = month;
            Year = year;
        }
        public MyDate(DateTime myDate)
        {
            this.myDate = myDate;
        }
        //public static MyDate operator - (MyDate d1, MyDate d2)
        //{
        //    return d1 - d2;
        //}
        public static int operator - (MyDate date1, MyDate date2)
        {
            DateTime d1 = new DateTime(date1.Year, date1.Month, date1.Day);
            DateTime d2 = new DateTime(date2.Year, date2.Month, date2.Day);
            TimeSpan difference = d1 - d2;
            return difference.Days;
        }

        //public void AddDay(double day)
        //{
        //   myDate =  myDate.AddDays(day);
        //}
        public static MyDate operator +(MyDate date, int days)
        {
            DateTime d = new DateTime(date.Year, date.Month, date.Day);
            d = d.AddDays(days);
            return new MyDate(d.Day, d.Month, d.Year);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int cx = 3;
                //DateTime date1 = new DateTime(2015, 6, 3);
                //DateTime date2 = new DateTime(2014, 12, 6);
                //MyDate myDate = new MyDate(date1);
                //MyDate myDate1= new MyDate(date2);
                MyDate myDate = new MyDate(18, 07, 1997);
                MyDate myDate1 = new MyDate(10, 07, 1997);
                Console.WriteLine(myDate-myDate1);
                myDate = myDate + 3;
                Console.WriteLine(myDate.Day);
               
                Console.WriteLine();
            }
        }
    }
}