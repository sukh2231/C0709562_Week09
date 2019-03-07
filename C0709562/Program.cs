using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C0709562_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Name Sukhraj singh Singh Student Id C0709562
            //CSD3354 Section 2 
            //Assignmnet 2
            //March 7,2019
            DelegateExcercises a = new DelegateExcercises();
            a.Method2();
        }
    }


    public class DelegateExcercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }

}

