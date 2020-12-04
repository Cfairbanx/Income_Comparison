using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate: ");
            string hourlyRate1 = Console.ReadLine();
            float perHour1 = float.Parse(hourlyRate1);
            Console.WriteLine("Please enter your hours worked per year: ");
            string hoursPerWeek1 = Console.ReadLine();
            float perWeek1 = float.Parse(hoursPerWeek1);
            float weeklyIncome1 = perHour1 * perWeek1;
            float annualIncome1 = weeklyIncome1 * 52;



            

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate: ");
            string hourlyRate2 = Console.ReadLine();
            float perHour2 = float.Parse(hourlyRate2);
            Console.WriteLine("Please enter your hours worked per year: ");
            string hoursPerWeek2 = Console.ReadLine();
            float perWeek2 = float.Parse(hoursPerWeek2);
            float weeklyIncome2 = perHour2 * perWeek2;
            float annualIncome2 = weeklyIncome2 * 52;

            Console.WriteLine("Annual salary of Person 1: " + annualIncome1);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2: " + annualIncome2);
            Console.ReadLine();

            bool makeMore = annualIncome1 > annualIncome2;

            Console.WriteLine("Does Person 1 make more than Person 2? " + makeMore);
            Console.ReadLine(); 


        }
    }
}
