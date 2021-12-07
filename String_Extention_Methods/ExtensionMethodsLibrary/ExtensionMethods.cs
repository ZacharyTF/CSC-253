using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLibrary
{
    public static class ExtensionMethods
    {
        public static void ToAnCharacterArray(this string userInput)
        {
            char[] charset = userInput.ToCharArray();
        }
        
        public static string DateExtension(this string str)
        {
            string dateFormat;

            char[] delim = { '/' };

            string[] token = str.Split(delim);

            if (token.Length == 3)
                dateFormat = token[1] + "/" + token[0] + "/" + token[2];
            else
                dateFormat = str;
            return dateFormat;
        }

        public static string IsAPhoneNumber(this string userInput)
        {
            string phoneNum;

            userInput.ToAnCharacterArray();

            if (userInput.Length == 10)
                phoneNum = "(" + userInput[0] + userInput[1] + userInput[2] + ") " + userInput[3] + userInput[4] + userInput[5] + "-" + userInput[6] + userInput[7] + userInput[8] 
                    + userInput[9];
            else
                phoneNum = userInput;
            return phoneNum;
        }

        public static string ReverseInput(this string @userText)
        {
            if(@userText.Length <= 1)
            {
                return @userText;
            }

            char[] chars = @userText.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static string CountText(this string userInput)
        {
            if(userInput.Length <= 1)
            {
                return userInput;
            }

            char[] chars = { ' ' };
            string[] words = userInput.Split(chars);
            string numberOfWords = words.Length.ToString();
            return numberOfWords;
        }
    }
}
