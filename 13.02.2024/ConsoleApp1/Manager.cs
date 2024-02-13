using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Manager : Employee
    {

        /// <summary>
        /// объем продаж
        /// </summary>
        private double salesVolume;

        public double SalesVolume { get { return salesVolume; } set { salesVolume = value; } }

        /// <summary>
        /// без параметров
        /// </summary>
        public Manager()
        {

        }


        public Manager(string name, string surname, DateTime bh, int p,  double salesVolume) : base(name, surname,bh, p)
        {

            this.salesVolume = salesVolume;

        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Объем продаж: {salesVolume}");
        }


        public override double Income(double k)
        {

            return base.Income(k);
            Console.WriteLine("Доход менеджера: ");
            double h = Convert.ToDouble(Console.ReadLine());

        }






    }
}
