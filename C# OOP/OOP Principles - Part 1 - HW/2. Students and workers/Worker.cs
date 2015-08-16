using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Students_and_workers
{
    public class Worker: Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        private const double workingDayPerWeek = 7;

        public Worker (string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Week salary must be positive!");
                
                this.weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Work hour per day must be positive or zero!");
                
                this.workHoursPerDay = value; }
        }
        public double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary/(this.WorkHoursPerDay*workingDayPerWeek);

            return moneyPerHour;
        }
    }
}
