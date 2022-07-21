using System;

namespace Foreach_Loops_and_Switch_Statement_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false; //for talking about a valid or invalid datatype -- WHY IS IT PRESELECTED AS FALSE?
            string inputValueType;

            Console.WriteLine("Enter any value: ");
            string inputValue = Console.ReadLine();
            Console.WriteLine("select the datatype to validate the input you have entered: \n Press 1 and enter for String \n Press 2 and enter for Integer \n Press 3 and enter for Boolean");

            int inputType = Convert.ToInt32(Console.ReadLine()); //nie string tylko int bo wpisuje cyfre?? ale czemu convert to int skoro juz jest int?????


            switch (inputType)
            {
                case 1: //checking for string
                    valid = onlyLetters(inputValue); //a new method needs to be created, "onlyLetters", that checks if the inputValue is only letters
                    //what does "valid" mean??? how s it assigned that's it's valid???
                    inputValueType = "String";
                    break;
                case 2: //checking for integer
                    int returnValue = 0; //why 0? i dont know what sb will input as Int!!
                    valid = int.TryParse(inputValue, out returnValue);
                    inputValueType = "Integer";
                    break;
                case 3: //checking for boolean
                    bool returnFlag = false; // WTF is a return "Flag"???
                    valid = bool.TryParse(inputValue, out returnFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect the input type");
                    break;
            }

            Console.WriteLine($"You have entered value: {inputValue}");
            if (valid)
            {
                Console.WriteLine($"It is a valid {inputValueType}");
            }
            else
            {
                Console.WriteLine($"It is an invalid {inputValueType}");
            }
        }
                //if (int.TryParse(input, out inputIntoInt)) - i can make it into a catch block to catch cases it cant parse it

        static bool onlyLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c)) // checking if each character in the string isn't a letter
                    return false; // then return false
            }

            return true; // if each character is a letter, return true
            }




    }
}
    

