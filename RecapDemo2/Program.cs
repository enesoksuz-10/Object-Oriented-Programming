using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            CustomerManager.Logger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger{ get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }
    class DatabaseLogger:ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged!");
        }

        public void log()
        {
            throw new NotImplementedException();
        }
    }
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file!");
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }

    interface ILogger
    {
        void log();
        void Log();
    }
}
