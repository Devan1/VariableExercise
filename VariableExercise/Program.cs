using System;

namespace VariableExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user_name;
            int age;
            char first_initial;
            bool true_false;
            double a;
            decimal b;
            

            user_name = "Devan";
            age = 34;
            first_initial = 'D';
            true_false = true;
            a = 64;
            b = 13.2m;
            

            Console.WriteLine(user_name);
            Console.WriteLine(age);
            Console.WriteLine(first_initial);
            Console.WriteLine(true_false);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"My name is {user_name}, and I am {age} years old. ");
          
        }
    }
}
