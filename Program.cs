using System;
namespace PowerOfTwoReview
{
    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Welcome to the Power of Two Program");
            Console.WriteLine("please Enter Value for upto which want the Power Value ");
           
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            const int y = 2;
            for(int i = 0; i < n; i++)
            {
                x = x * y;
            }
            Console.WriteLine("The Power of Two is : " + x);
        }
    }
}