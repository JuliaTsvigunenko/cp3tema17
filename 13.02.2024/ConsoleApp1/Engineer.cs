using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engineer : Employee
    {



        private int n;

        public int N { get { return n; } set { n = value; } }

        
        public Engineer()
        {

        }

        public Engineer (string name, string surname, DateTime bh, int p, int n): base(name, surname, bh, p)
        {
            this.n = n;
        }

        public override void ShowInfo ()
        {
            base.ShowInfo();
            Console.WriteLine($"Кол-во разработанных проектов: {n}");
        }

        public override double Income(double k)
        {
            return base.Income(k);
            Console.WriteLine("Кол-во разработанных проектов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            return 4.8 * n;
        }








    }
}
