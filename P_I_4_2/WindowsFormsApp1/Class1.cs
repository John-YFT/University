using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Date
    {
            private int month;
            private int day;
            private int year;


            public int Year
            {
                get
                { return year; }
                set
                {
                    if (value > 0)
                    { year = value; }
                    else
                    {
                        year = 0;
                    }

                }
            }

            public int Month
            {
                get
                { return month; }
                set
                {
                    if ((0 < value) & (value <= 12))
                    { month = value; }
                    else
                    {
                        month = 0;
                    }

                }
            }

            public int Day
            {
                get
                {
                    return day;
                }
                set
                {
                    if ((0 < value) & (value <= KolDay(month, year)))
                    { day = value; }
                    else
                    {
                        day = 0;
                    }

                }
            }
            public Date(int year, int month, int day)
            {
                this.year = year;
                this.month = month;
                this.day = day;
            }
            public Date()
            {
                this.year = 0;
                this.month = 0;
                this.day = 0;
            }

            public bool inDate(ref Date date)
            {
                int day = Convert.ToInt32(Console.ReadLine());
                int month = Convert.ToInt32(Console.ReadLine());
                int year = Convert.ToInt32(Console.ReadLine());
                date.Year = year;
                if (date.Year == 0)
                    return false;
                date.Month = month;
                if (date.Month == 0)
                    return false;
                date.Day = day;
                if (date.Day == 0)
                    return false;
                return true;
            }
            public bool VisYear(Date date)
            {
                if (date.year % 4 == 0)
                    return true;
                else
                    return false;
            }

            public override string ToString() => "Дата: \n \t" + this.day + "." + this.month + "." + this.year;

            public int KolDay(int date, int year)
            {
                switch (date)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        return 31;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;

                    case 2:
                        if (year % 4 == 0)
                            return 29;
                        else
                            return 28;
                }
                return 0;
            }

            public Date VichDate(Date date, int kol_day)
            {
                Date date_1 = new Date(date.year, date.month, date.day + kol_day);
                int KolDay = date.KolDay(date.month, date.year);
                while (date_1.day > KolDay)
                {
                    date_1.day -= KolDay;
                    date_1.month += 1;
                    if (date_1.month > 12)
                    {
                        date_1.month -= 12;
                        date_1.year += 1;
                    }
                }
                return date_1;
            }

            public int PromDate(Date date_1, Date date_2)
            {
                if ((date_1.day == date_2.day) & (date_1.month == date_2.month) & (date_1.year == date_2.year))
                    return 0;
                else
                {
                    if (date_1.year == date_2.year)
                    {
                        int kol_day_1 = date_1.day;
                        int kol_day_2 = date_2.day;
                        if (date_1.month != date_2.month)
                        {
                            for (int i = 1; i < date_1.month; i++)
                                kol_day_1 += KolDay(i, date_1.year);
                            for (int i = 1; i < date_2.month; i++)
                                kol_day_2 += KolDay(i, date_2.year);
                        }
                        return (Math.Abs(kol_day_1 - kol_day_2));
                    }
                    else
                    {
                        Date kmin, kmax;
                        if (date_1.year < date_2.year)
                        {
                            kmin = date_1;
                            kmax = date_2;
                        }
                        else
                        {
                            kmin = date_2;
                            kmax = date_1;
                        }
                        int kol_day = (KolDay(kmin.month, kmin.year) - kmin.day) + kmax.day;
                        for (int i = kmin.month + 1; i <= 12; i++)
                        {
                            kol_day += KolDay(i, kmin.year);
                        }
                        for (int i = kmin.year + 1; i < kmax.year; i++)
                        {
                            if (i % 4 == 0)
                                kol_day += 366;
                            else
                                kol_day += 365;
                        }
                        for (int i = 1; i < kmax.month; i++)
                        {
                            kol_day += KolDay(i, kmax.year);
                        }
                        return kol_day;
                    }
                }
            }

            public static bool operator >(Date date_1, Date date_2)
            {
                if ((date_1.year > date_2.year) | ((date_1.year >= date_2.year) & (date_1.month > date_2.month)) | ((date_1.year >= date_2.year) & (date_1.month >= date_2.month) & (date_1.day > date_2.day)))
                    return true;
                else
                    return false;
            }
            public static bool operator <(Date date_1, Date date_2)
            {
                if ((date_1.year < date_2.year) | ((date_1.year <= date_2.year) & (date_1.month < date_2.month)) | ((date_1.year <= date_2.year) & (date_1.month <= date_2.month) & (date_1.day < date_2.day)))
                    return true;
                else
                    return false;
            }
            public static Date operator -(Date date, int kol_day)
            {
                date.day -= kol_day;
                while (date.day <= 0)
                {
                    date.month -= 1;
                    if (date.month < 1)
                    {
                        date.month += 12;
                        date.year -= 1;
                    }
                    date.day = date.KolDay(date.month, date.year) - Math.Abs(date.day);
                }
                return date;
            }
        }
    }

