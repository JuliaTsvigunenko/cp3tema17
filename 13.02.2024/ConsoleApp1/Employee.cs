using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {



        /// <summary>
        /// имя
        /// </summary>
        private string name;

        /// <summary>
        /// фамилия
        /// </summary>
        private string surname;

        /// <summary>
        /// поле даты рождения
        /// </summary>
        private DateTime bh;

        /// <summary>
        /// минимальная зарплата
        /// </summary>
        private double p;



        /// <summary>
        /// свойства
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public DateTime Bh { get { return bh; } set { bh = value; } }
        public double P { get { return p; } set { p = value; } }



        /// <summary>
        /// по умолчанию
        /// </summary>
        public Employee()
        {

        }


        /// <summary>
        /// с параметрами
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="bh">дата рождения</param>
        /// <param name="p">минимальная зп</param>
        public Employee(string name, string surname, DateTime bh, double p)
        {
            this.name = name;
            this.surname = surname;
            this.bh = bh;
            this.p = p;
        }

        /// <summary>
        /// Виртуальные метод вывода информации о сотруднике
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Имя сотрудника: {name}\nФамилия сотрудника: {surname}\nДень рождения сотрудника: {bh.ToShortDateString()}\nМинимальна зарплата: {p}");
        }


        /// <summary>
        /// Виртуальный метод вычисления дохода
        /// </summary>
        /// <returns></returns>
        public virtual double Income(double k)
        {

            return k * p;
        }






    }
}
