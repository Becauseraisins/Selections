using System;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age in years");
            string age = Console.ReadLine();
            int ageNum = int.Parse(age);
        
            Console.WriteLine("please enter your gender M/F");
            string gender = Console.ReadLine();
           
             
            if(ageNum>17){
                //true path
                if(gender=="M"){
                Console.WriteLine("Male adult");
                }   

                if(gender=="F"){
                Console.WriteLine("Female Adult");
                }
                }
            
            
            else{
                //false path
                if(gender=="M"){
                Console.WriteLine("Male is not an Adult");
                }

                if(gender=="F"){
                Console.WriteLine("Female is not an Adult");
                }
                
               }
          }
    }
}
 