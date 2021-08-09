using System;
using System.Collections.Generic;



namespace Lab4_3
{
    class Customer
    {
        //part1
        private string pCompany;
        private string pContactName;
        private string pContactEmail;
        private string pPhone;

        //create a getter and setter for each feied and make them public

        public string GetCompany()
        {
            return pCompany;
        }
        public void SetCompany(string _Company)
        {
            pCompany = _Company;
        }

        public string GetContactName()
        {
            return pContactName;
        }
        public void SetContactName(string _ContactName)
        {
            pContactName = _ContactName;
        }

        public string GetContactEmail()
        {
            return pContactEmail;
        }
        public void SetContactEmail(string _ContactEmail)
        {
            pContactEmail = _ContactEmail;
        }
        public string GetPhone()
        {
            return pPhone;
        }
        public void SetPhone(string _Phone)
        {
            pPhone = _Phone;
        }

        public Customer(string _Company, string _ContactName, string _ContactEmail, string _Phone)
        {

            SetCompany(pCompany);
            SetContactEmail(pContactEmail);
            SetContactName(pContactName);
            SetPhone(pPhone);
        }


        public override string ToString()
        {
            return $"{pCompany} {pContactEmail} {pContactName} {pPhone}";
        }




    }


    class Program
    {
        //part2


        static void ListCustomers(List<Customer> customerList)
        {
            foreach (Customer next in customerList)
            {
                Console.WriteLine(next);
            }
        }


        static void Main(string[] args)
        {
                                       
            List<Customer> Customers = new List<Customer>();

            //Customer c1 = new Customer();
            //c1.SetCompany = "Quicken";
            //c1.SetContactEmail = "Help@QuickenLoans.com";
            //c1.SetContactName = "Asia";






            //Customer newCustomer = new Customer();
            //Customers.Add(newCustomer);

            //newCustomer = new Customer("Quicken", "Sally", "Sally@quicken.com", "3133333333");
            //Customers.Add(newCustomer);
        }
    }
}
