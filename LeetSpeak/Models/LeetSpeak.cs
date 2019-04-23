using System;

namespace LeetSpeak
{
    public class LeetSpeak
    {
        // Replaces characters based on the following rules:
        // * "e" should be replaced with "3".
        // * "o" should be replaced with "0".
        // * Capital (not the lowercase "I" should be replaced with "1".
        // * "t" should be replaced with "7".
        // * "s" should be replaced with "z", unless it is the first letter of a word.
        public string Translate(string userInput)
        {
            char[] inputArray = userInput.ToCharArray();
            for (int i=0; i < inputArray.Length; i++)
            {
                switch (inputArray[i])
                {
                    case 'e':
                        inputArray[i] = '3';
                        break;
                    case 'o':
                        inputArray[i] = '0';
                        break;
                    case 'I':
                        inputArray[i] = '1';
                        break;
                    case 't':
                        inputArray[i] = '7';
                        break;
                }
            }
            string result = string.Join("", inputArray);
            return result;
        }
    }
}