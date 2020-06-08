/* MathTutor.cs		Author:	Miringen Zefi	
 * Gives user the menu option to select what kind
 * of math skills they want to do. Once selected 
 * user will get random numbers of the math skill they
 * selected and user will enter the answer and will get the results
 * if they were correct or not. When user is finished, it will display
 * their name and grade along with the number of each math skill asked
 * and answered correctly.
 * **************************************/

using System;
using static System.Console;

namespace MathTutorApp
{
    public class MathTutor
    {
        private string userName;
        private int grade;
        private int numOfAdditionCorrect;
        private int numOfSubtractionCorrect;
        private int numOfMultiplicationCorrect;
        private int numOfAdditionAsked;
        private int numOfSubtractionAsked;
        private int numOfMultiplicationAsked;
        Random random = new Random();

        public MathTutor()
        {

        }
        public MathTutor(string name, int gradeLevel)
        {
            userName = name;
            grade = gradeLevel;

            Write("\n" + userName + ", we appreciate you using the Math Tutor App. When you are ready to be tested on Math skills, please press any key to continue.");
            ReadKey();
            Clear();
            Menu();
        }

        public string UserName
        {
            get
            {
                return userName;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }
        }

        public void Menu()
        {
            int inputValue;
            Write("Specify the math skill that you would like to be tested. The following are your options: ");
            Write("\nAddition - Enter 1" +
                  "\nSubtraction - Enter 2" +
                  "\nMultiplication - Enter 3" +
                  "\nSurprise Me - Enter 4\n");
            Write("Enter your testing option: ");
            inputValue = int.Parse(ReadLine());
            Clear();
            SettingNums(inputValue);
        }

        public void SettingNums(int skill)
        {
            int firstNum;
            int secondNum;
            int randSkill = skill;
            if (skill == 4)
            {
                randSkill = random.Next(1, 4);
            }
            switch (grade)
            {
                case 1:
                    firstNum = random.Next(75);
                    secondNum = random.Next(75);
                    break;
                case 2:
                    firstNum = random.Next(99);
                    secondNum = random.Next(99);
                    break;
                case 3:
                    firstNum = random.Next(125);
                    secondNum = random.Next(125);
                    break;
                case 4:
                    firstNum = random.Next(150);
                    secondNum = random.Next(150);
                    break;
                case 5:
                    firstNum = random.Next(200);
                    secondNum = random.Next(200);
                    break;
                default:
                    firstNum = random.Next(50);
                    secondNum = random.Next(50);
                    break;
            }
            Calculate(randSkill, skill, firstNum, secondNum);
        }
        public void Calculate(int randSkill, int skill, int firstNum, int secondNum)
        {
            int inputVal;
            switch (randSkill)
            {
                case 1:
                    Write("What is " + firstNum + " + " + secondNum + ": ");
                    inputVal = int.Parse(ReadLine());
                    if(inputVal == (firstNum +secondNum))
                    {
                        Write("Very Good\n");
                        numOfAdditionCorrect++;

                    }
                    else
                    {
                        Write("Sorry that is not correct! The correct answer is " + (firstNum + secondNum) + "\n");
                    }
                    numOfAdditionAsked++;
                    break;
                case 2:
                    if(firstNum < secondNum)
                    {
                        firstNum = random.Next(secondNum, 200);
                    }
                    Write("What is " + firstNum + " - " + secondNum + ": ");
                    inputVal = int.Parse(ReadLine());
                    if (inputVal == (firstNum - secondNum))
                    {
                        Write("Excellent!\n");
                        numOfSubtractionCorrect++;
                    }
                    else
                    {
                        Write("Come on " + userName + ", you need to work on your subtraction skills. The correct answer is " + (firstNum - secondNum) + "\n");
                    }
                    numOfSubtractionAsked++;
                    break;
                case 3:
                    Write("What is " + firstNum + " x " + secondNum + ": ");
                    inputVal = int.Parse(ReadLine());
                    if (inputVal == (firstNum * secondNum))
                    {
                        Write("Nice Work, " + userName + ". Let's go one more round.\n");
                        numOfMultiplicationCorrect++;
                    }
                    else
                    {
                        Write("Wrong. The correct answer is " + (firstNum * secondNum) + "\n");
                    }
                    numOfMultiplicationAsked++;
                    break;
                default:
                    break;
            }
            Write("\nTo continue to display next quesiton, press c, To go back to the menu, press m. To stop testing, press any other key\n ");
            ConsoleKeyInfo keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.C:
                    {
                        Clear();
                        SettingNums(skill);
                        break;
                    }
                case ConsoleKey.M:
                    {
                        Clear();
                        Menu();
                        break;
                    } 
                default:
                    Clear();
                    break;
            }

        }

        public override string ToString()
        {
            return "Name:" + userName + "\nGrade:" + grade + "\n\nNumber of Addition Questions Asked:" + numOfAdditionAsked +
                "\nNumber of Addition Questions Answered Correctly:" + numOfAdditionCorrect + "\n\nNumber of Subtraction Questions Asked:" +
                numOfSubtractionAsked + "\n Number of Subtraction Questions Answered Correctly:" + numOfSubtractionCorrect + "\n\nNumber of Multiplication Questions Asked:"
                + numOfMultiplicationAsked + "\nNumber of Multiplication Questions Answered Correctly:" + numOfMultiplicationCorrect + "\n\nThank You for using the Math Tutor App, " +
                "We hope to see you back for practicing your math skills";
        }
    }
}
