using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Class;

namespace Time_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            // Time is the type(class) and soft151Time is a new object(var)

            Console.WriteLine("Please input the hour");

            int h =(Convert.ToInt32(Console.ReadLine()));

            Time soft151Time;
            soft151Time = new Time(h);
            
            



            soft151Time = new Time(16, 05, 00);

            string output;
            output = soft151Time.GetCurrentTime();


            Console.WriteLine(output);
            Console.ReadLine();
        }

    }
}
