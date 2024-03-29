using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorbitTask
{
    public class BMIstat : IStatistics
    {
        Person person;
        private double stats;
        private string classOfBMI;
        public BMIstat(Person p) {
            person = p;
            classOfBMI = "";
        }
        public double CountStatistic()
        {
            stats = person.Weight / Math.Pow(person.Height,2);
            return stats;
        }

        public void DefineClassOfBMI()
        {
            if (stats < 18.5) classOfBMI = "Дефицит массы тела";
            else if (stats < 25) classOfBMI = "Норма";
            else if (stats < 30) classOfBMI = "Избыточная масса тела";
            else if (stats < 35) classOfBMI = "Ожирение 1 степени";
            else if (stats < 40) classOfBMI = "Ожирение 2 степени";
            else classOfBMI = "Ожирение 3 степени";
        }

        public void PrintStatistic()
        {
            CountStatistic();
            DefineClassOfBMI();
            Console.WriteLine($"ИМТ:{stats}, который соответствует уровню {classOfBMI}");
        }
    }
}
