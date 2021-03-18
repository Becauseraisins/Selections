using System;

namespace selection_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers");
            string input1= Console.ReadLine();
            string input2= Console.ReadLine();

            int num1= int.Parse(input1);
            int num2= int.Parse(input2);

            if (num1+num2>10){
                Console.WriteLine("this number is greater than 10");
            }
            if(num1+num2<10){
                Console.WriteLine("this number is less than 10");
            }
            if(num1+num2==10){
                Console.WriteLine("10!");
            }
            {
                
            }
        
        }
    }
}
