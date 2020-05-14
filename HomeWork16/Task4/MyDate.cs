using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class MyDate
    {
        public int day, month, year;

        public MyDate(int year, int month, int day)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public static int operator ==(MyDate myDate1, MyDate myDate2)
        {
            int dif = 0;
            if (myDate1.year >= myDate2.year)
            {
                dif += (myDate1.year - myDate2.year) * 365;
                if (myDate1.month >= myDate2.month)
                {
                    dif += ((myDate1.month - myDate2.month) * 30);
                }
                else
                {
                    dif -= 365;
                    dif += ((myDate1.month - myDate2.month + 12) * 30);
                }
                if (myDate1.day >= myDate2.day)
                {
                    dif += myDate1.day - myDate2.day;
                }
                else
                {
                    dif -= 30;
                    dif += (myDate1.day - myDate2.day + 30);
                }

            }
            else
            {
                dif += ((myDate2.year - myDate1.year) * 365);
                if (myDate2.month >= myDate1.month)
                {
                    dif += ((myDate2.month - myDate1.month) * 30);
                }
                else
                {
                    dif -= 365;
                    dif += ((myDate2.month - myDate1.month + 12) * 30);
                }
                if (myDate2.day >= myDate1.day)
                {
                    dif += myDate2.day - myDate1.day;
                }
                else
                {
                    dif -= 30;
                    dif += (myDate2.day - myDate1.day + 30);
                }

            }
            return dif;
        }
        public static int operator !=(MyDate myDate1, MyDate myDate2)
        {
            int dif = 0;
            if (myDate1.year >= myDate2.year)
            {
                dif += ((myDate1.year - myDate2.year) * 365);
                if (myDate1.month >= myDate2.month)
                {
                    dif += ((myDate1.month - myDate2.month) * 30);
                }
                else
                {
                    dif -= 365;
                    dif += ((myDate1.month - myDate2.month + 12) * 30);
                }
                if (myDate1.day >= myDate2.day)
                {
                    dif += myDate1.day - myDate2.day;
                }
                else
                {
                    dif -= 30;
                    dif += (myDate1.day - myDate2.day + 30);
                }

            }
            else
            {
                dif += ((myDate2.year - myDate1.year) * 365);
                if (myDate2.month >= myDate1.month)
                {
                    dif += ((myDate2.month - myDate1.month) * 30);
                }
                else
                {
                    dif -= 365;
                    dif += ((myDate2.month - myDate1.month + 12) * 30);
                }
                if (myDate2.day >= myDate1.day)
                {
                    dif += myDate2.day - myDate1.day;
                }
                else
                {
                    dif -= 30;
                    dif += (myDate2.day - myDate1.day + 30);
                }

            }
            return dif;
        }
        public static MyDate operator +(MyDate myDate1, int days)
        {
            myDate1.day += days;
            while (true)
            {
                if (myDate1.day > 30)
                {
                    myDate1.day -= 30;
                    myDate1.month++;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (myDate1.month > 12)
                {
                    myDate1.month -= 12;
                    myDate1.year++;
                }
                else
                {
                    break;
                }
            }
            return myDate1;
        }
    }
}
