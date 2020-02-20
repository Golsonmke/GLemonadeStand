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
        public bool sellLemonade;
        

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            this.sellLemonade = false;
           
            
        }
        // can do?
       
        public bool CanSellLemonade(Pitcher pitcher)
        {



            sellLemonade = false;

            do
            {


                if (pitcher.cupsLeftInPitcher <= 1)
                {
                    sellLemonade = false;
                    return false;
                }

            } while (sellLemonade == true);
            return true;
            
            

        }
        public void GetCustomer()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customers);
            }
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
      
        
        public void EndOfDayReport()
        {
            
        }
       
    }

}
