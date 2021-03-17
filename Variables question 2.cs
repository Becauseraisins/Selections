using System;

namespace selection_2
{
    class Program
    {
        static void Main(string[] args)
        {// input for username and password 
            Console.WriteLine("Please Enter Username");
            string username=Console.ReadLine();

            Console.WriteLine("please Enter Password");
            string password= Console.ReadLine();
         // strings being used here as the 'correct' login details
                string user1 =("admin");
                string user1pass =("letmein");
        //if/else statements checking for the only acceptable login, honestly not certain how to get it to check for multiple valid logins or check against a database of logins 
            if (username==user1){
                if(password==user1pass){
                    Console.WriteLine("login successful");
                }

            }else{
                 Console.WriteLine("login failed");
            }
        }
    }
}
