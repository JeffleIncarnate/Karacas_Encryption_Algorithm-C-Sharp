using System;

namespace Karacas_Encryption_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string? userInput = "Test";

            List<char> userInputList = new List<char>();
            Console.Write("Please enter word: ");
            userInput = Console.ReadLine();

            // reverse the userInput string
            string reversedInput = ReverseString(userInput);

            for (int i = 0; i < reversedInput.Length; i++)
            {
                if (reversedInput[i] == 'a')
                {
                    userInputList.Add('0');
                }
                else if (reversedInput[i] == 'e')
                {
                    userInputList.Add('1');
                }
                else if (reversedInput[i] == 'i')
                {
                    userInputList.Add('2');
                }
                else if (reversedInput[i] == 'o')
                {
                    userInputList.Add('2');
                }
                else if (reversedInput[i] == 'u')
                {
                    userInputList.Add('3');
                }
                else
                {
                    userInputList.Add(reversedInput[i]);
                }
            }

            userInputList.Add('a');
            userInputList.Add('c');
            userInputList.Add('a');

            foreach (char item in userInputList)
            {
                Console.Write(item);
            }

            static string ReverseString(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
}