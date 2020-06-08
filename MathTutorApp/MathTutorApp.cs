/* MathTutorApp.cs		Author:	Miringen Zefi	
 * This is the start of the program where
 * the user gets introduced to the app and 
 * is where the user inputs their information
 * such as full name and grade level and then
 * the function creates an object of mathtutor 
 * and goes through it.
 * **************************************/

using System;
using static System.Console;

namespace MathTutorApp
{
    class MathTutorApp
    {
        static void Main(string[] args)
        {
            string name;
            int gradeLevel;

            WriteLine("Welcome to the Math Tutor App!");
            WriteLine();
            WriteLine("This app will ask you questions on basic mathmatics skills that an elementary student should master.");
            WriteLine();
            WriteLine("We would like to get some basic infomation from you.");
            WriteLine();
            GetInputValues(out name, out gradeLevel);
            MathTutor mathtutors = new MathTutor(name, gradeLevel);
            WriteLine(mathtutors);
        }


        public static void GetInputValues(out string name, out int gradeLevel)
        {
            string inputValue;
            Write("To get started, please provide your full name: ");
            inputValue = ReadLine();
            name = inputValue;
            Write("Enter your grade level (1-5): ");
            inputValue = ReadLine();
            gradeLevel = int.Parse(inputValue);
        }
    }
}
