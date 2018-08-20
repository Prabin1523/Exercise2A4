using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a console application that will accept a number test scores(as calculated by the number of scores actually entered) between 0 and 
            100, average them, and report a letter grade for the average based on the usual scale.For example, a teacher will input any number
            test scores, and see the average numerical grade and the letter grade.
            */
            Console.WriteLine("Enter any numbers between 0 and 100. Once you are done Typing, Enter '00' and press Enter");

            int sum = int.Parse(Console.ReadLine());
            int avgTestScores = 0;
            int index = 0;

            while (sum != 0)
            {
                avgTestScores += sum;
                index++;
                //Console.WriteLine(" Enter another numbers between 0 and 100");
                sum = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("The average test scores is: {00}", avgTestScores/index);
        
        }
    }
}
