using System;

namespace LeetSpeak
{
    public class LeetSpeak
    {
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
                    // default:
                    //     inputArray[i] = inputArray[i];
                }
            }
            string result = string.Join("", inputArray);
            return result;
        }
    }
}