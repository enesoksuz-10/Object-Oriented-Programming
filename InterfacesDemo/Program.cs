﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3];
            {
                new Manager();
                new Worker();
                new Robot();
            }
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats=new IEat[2];
            {
                new Worker();
                new Manager();
            }
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface Ieat
    {
        void eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, Ieat, ISalary
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, Ieat, ISalary
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
