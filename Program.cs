using System;

namespace GitDemo1
{
    class Customer
    {
        String _fname;
        string _lname;

        public Customer(string firstname, string lastname)
        {
            _fname = firstname;
            _lname = lastname;
        }

        public string PrintFullName()
        {
            return _fname + " " + _lname;
        }
        ~Customer()
        {

        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Sazid", "Shaik");
            Console.WriteLine(c1.PrintFullName());
        }
        
    }
}
