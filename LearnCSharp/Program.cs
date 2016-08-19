using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp //Comment
{
    class HelloWorld
    {
        //Github Test Change - Version Control
        string name = "Anand";
        string greeting = "Good Evening";

        public void RunHelloWorld()
        {
            Console.WriteLine(name);
            Console.WriteLine($"Hello {greeting}!");
            Console.WriteLine($"{greeting} Anand");
            Console.ReadLine();
        } 
    }
    class CreateStringTest
    {
        string string1 = "Hello";
        string string2 = "Anand";
        string emptrystring = string.Empty;
        string nullstring = null;

        public void RunStringTest()
        {
           Console.WriteLine(string1);
           Console.WriteLine(string2);
           Console.WriteLine(emptrystring);
           //Console.WriteLine(nullstring);
           Console.WriteLine($"1st String Length is {emptrystring.Length} characters long");
           //Console.WriteLine($"2nd String Length is {nullstring.Length} characters long");
           Console.ReadLine();

           if (string.IsNullOrEmpty(nullstring))
                Console.WriteLine("Empty String");
           else
                Console.WriteLine("Test");
                Console.ReadLine();

            string input = " Anand ";
            string clean1 = input.TrimStart();
            string clean2 = input.TrimEnd();
            string clean3 = input.Trim();
            string shortversion = input.Trim().Substring(0, 3);

            Console.WriteLine($"*{input}*");
            Console.WriteLine($"*{clean1}*");
            Console.WriteLine($"*{clean2}*");
            Console.WriteLine($"*{clean3}*");
            Console.WriteLine($"*{shortversion}*");
            Console.ReadLine();

            string name = "Anand";
            string name2 = "Anand K";
            string greet1 = $"Hello {name}!";
            string greet2 = "Hello " + name + "!";
            string greet3 = string.Format("Hello {0}!", name);
            string greetTemplate = "Hello **NAME**!";
            string greet4 = greetTemplate.Replace("**NAME**", name);
            string greet5 = greetTemplate.Replace(greetTemplate, name2);

            Console.WriteLine(name);
            Console.WriteLine(greet1);
            Console.WriteLine(greet2);
            Console.WriteLine(greet3);
            Console.WriteLine(greetTemplate);
            Console.WriteLine(greet4);
            Console.WriteLine(greet5);
            Console.ReadLine();

            string name3 = "Jack The Ripper";
            string name4 = name3.ToUpper();

            Console.WriteLine($"Hello, {name4} .");
            Console.ReadLine();
        }

    }

    class datetimetest
    {
        public void rundatetimetest()
        {
            var currentTime = DateTime.Now;
            var today = DateTime.Today;
            var someDate = new DateTime(2016, 7, 1);
            var someMoment = new DateTime(2016, 7, 1, 8, 0, 0);
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("7/1/2016");

            Console.WriteLine(currentTime);
            Console.WriteLine(today);
            Console.WriteLine(someDate);
            Console.WriteLine(someMoment);
            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);
            Console.WriteLine(someDay);
            Console.ReadLine();

            var sometime = new DateTime(2016, 6, 29, 15, 41, 12);
            int year = sometime.Year;
            int month = sometime.Month;
            int day = sometime.Day;
            int hour = sometime.Hour;
            int minute = sometime.Minute;
            int second = sometime.Second;

            Console.WriteLine($"{nameof(sometime)}: {sometime}");
            Console.WriteLine($"The Date & Time Is {sometime}");
            Console.WriteLine($"{nameof(year)}: {year}");
            Console.WriteLine($"{nameof(month)} : {month})");
            Console.WriteLine($"{nameof(day)} : {day}");
            Console.WriteLine($"{nameof(hour)} : { hour}");
            Console.WriteLine($"{nameof(minute)} : {minute}");
            Console.WriteLine($"{nameof(second)} : {second}");
            Console.ReadLine(); 
        }
    }

    class learnprogramdecision
    {
        public void greet(string name)
        {
            if (string.IsNullOrEmpty(name)) return;
            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
        }

        internal void greet()
        {
            throw new NotImplementedException();
        }
    }

    class testifelse
    {
        public void runtestifelse()
        {
            bool someCondition = true;

            var sum = 10;
            if (someCondition)
                //sum = sum + 5;
                sum = sum * 2;
            Console.WriteLine(sum);
            Console.ReadLine();

            Console.WriteLine("What Is The Capital of Malaysia?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "kuala lumpur")
            {
                Console.WriteLine("Correct!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, You Have Got The Wrong Answer.");
                Console.ReadLine();
            }
        }
           
    }

    class decisionifelse
    {
        public void rundecisionifelse()
        {
            int x,y;
            x = 25;
            y = 10;

            if (x < y)
            {
                Console.WriteLine("X is Smaller Then Y");
                Console.ReadLine();
            }
            else if (x > y)
            {
                Console.WriteLine("X is Bigger The Y");
                Console.ReadLine();
            }
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld HW = new HelloWorld();
            //HW.RunHelloWorld();

            //CreateStringTest CS = new CreateStringTest();
            //CS.RunStringTest();

            //datetimetest DT = new datetimetest();
            //DT.rundatetimetest();

            //learnprogramdecision PD = new learnprogramdecision();
            //PD.greet();

            //testifelse TIF = new testifelse();
            //TIF.runtestifelse();

            decisionifelse DIF = new decisionifelse();
            DIF.rundecisionifelse();
            
        }
    }
}
