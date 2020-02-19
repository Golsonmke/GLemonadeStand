using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
       //Has a
        public Weather weather;
        public List<Customer> customers;
        public Pitcher pitcher;
        

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
           
        }
        // can do?
        public void SellLemonade(Pitcher pitcher)
        {
            do
            {

            } while (true);
            
            
            

        }


        public void AddCustomerToList(int numberOfCustomers)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
              
            }
        }
        public void DeterminNumberOfCustomers()
        {
            if (weather.temperature >= 90)
            {
                AddCustomerToList(100);
            }
            if (weather.temperature >= 80)
            {
                AddCustomerToList(90);
            }
            if (weather.temperature >= 70)
            {
                AddCustomerToList(80);
            }
            else if (weather.temperature <= 60)
            {
                AddCustomerToList(50);
            }
           
            
        }
       
    }

}
