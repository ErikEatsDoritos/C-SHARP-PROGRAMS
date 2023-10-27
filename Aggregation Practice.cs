using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition
{
    internal class Program
    {
        public class Property
        {
            string Street;
            string City;
            int Number;
            int Cost;

            public Property(string Street, string City, int Number, int Cost)
            {
                this.Street = Street;
                this.City = City;
                this.Number = Number;
                this.Cost = Cost;
            }

            public int GetCost()
            {
                return Cost;
            }
        }
        public class Person
        {
            Property Home = null;
            string Name;
            int Money;

            public Person(string name, int money)
            {
                this.Name = name;
                this.Money = money;
            }

            public void BuyHome(Property home)
            {
                this.Money -= home.GetCost();
                this.Home = home;

            }
        }


        static void Main(string[] args)
        {
            Property Mansion = new Property("green rd", "Markham", 123, 1200);
            Person Erik = new Person("Erik", 1500);
            Console.WriteLine($"{Erik.Money}");
             
        }
    }
}
