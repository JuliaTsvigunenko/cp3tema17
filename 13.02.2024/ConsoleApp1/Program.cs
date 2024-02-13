using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Employee> employe = new List<Employee>();
            //employe.Add(new Employee("Юлия", "Цвигуненко", new DateTime(2006, 05, 19), 8000));
            //employe.Add(new Employee("Анастасия", "Федорова", new DateTime(2009, 02, 20), 4000));
            //employe.Add(new Employee("Ольга", "Ершова", new DateTime(1996, 06, 11), 10000));
            employe.Add(new Employee("Екатерина", "Минорова", new DateTime(2001, 11, 11), 9000));
            employe.Add(new Employee("Елизавета", "Ларина", new DateTime(2004, 08, 19), 11000));

            //employe.Add(new Manager("Арсений", "Ларин", new DateTime(1998, 03, 12), 6000, 11));
            //employe.Add(new Manager("Ирина", "Соколова", new DateTime(1982, 02, 02), 15000, 20));
            //employe.Add(new Manager("Игорь", "Ахмиров", new DateTime(2002, 07, 13), 5000, 5));
            employe.Add(new Manager("Олег", "Брагин", new DateTime(2000, 04, 12), 3000, 2));
            employe.Add(new Manager("Ольга", "Цуркан", new DateTime(1990, 04, 26), 9000, 16));


            foreach (Employee emp in employe)
            {
                emp.ShowInfo();
                Console.Write("Повышающий коэффициент: ");
                double k = Convert.ToDouble(Console.ReadLine());
                Console.Write("Кол-во раззработанных проектов: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Доход: {emp.Income(k)}");
            }
           

            Console.ReadKey();













        }
    }
}
