using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date
    {
        int year;
        int month;
        int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public void Add(int days)
        {
            this.day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            this.day += days;
            this.month += months;
            Normalize();
        }

        public void Add(Date other)
        {
            this.day += other.day;
            this.month += other.month;
            this.year += other.year;
            Normalize();
        }

        private void Normalize()
        {
            int numdays;
            while (this.day >30)
            {
                int curmonth = this.month % 12;
                switch (curmonth)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        numdays = 30;
                        break;
                    case 2:
                        if (this.year % 4 == 0)
                        {
                            numdays = 29;
                        }
                        else
                        {
                            numdays = 28;
                        }
                        break;
                    default:
                        numdays = 31;
                        break;
                }
                this.day -= numdays;
                this.month++;
                this.month %= 12;
                if (this.month / 12 >= 0)
                {
                    this.year += this.month / 12;
                }
            }
        }
        public override string ToString()
        {
            return $"Year: {year,10} Month: {month, 10} Date: {day,10}";
        }
    }
}
