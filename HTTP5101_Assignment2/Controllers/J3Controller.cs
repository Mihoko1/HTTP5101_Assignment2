using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Batch;

namespace HTTP5101_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {

        /// <summary>
        /// Receive input of words and provide how much time is need to type certain words on the cellphone.
        /// </summary>
        /// <param name="message">Input of words consisting only of lowercase letters and have at most 20 characters. When the word "halt" has been entered, the program should stop reading input. </param>
        /// <example>Get api/J3/Text/a -> "1"</example>
        /// <example>Get api/J3/Text/dada -> "4"</example>
        /// <example>Get api/J3/Text/bob -> "7"</example>
        /// <example>Get api/J3/Text/abba -> "12"</example>
        /// <example>Get api/J3/Text/cell -> "13"</example>
        /// <example>Get api/J3/Text/www -> "7"</example>
        /// <example>Get api/J3/Text/halt -> " "</example>
        /// <returns>The minimal number of seconds needed to type in the word</returns>

        [Route("api/J3/Text/{message}")]
        public string GetText(string message)
        {
            int count = 0;
            char prev = ' ';

            if (message == "halt")
            {
                return " ";
            }

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'a' || message[i] == 'd' || message[i] == 'g' || message[i] == 'j' || message[i] == 'm' || message[i] == 'p' || message[i] == 't' || message[i] == 'w')
                {
                    count = count + 1;
                }
                else if (message[i] == 'b' || message[i] == 'e' || message[i] == 'h' || message[i] == 'k' || message[i] == 'n' || message[i] == 'q' || message[i] == 'u' || message[i] == 'x')
                {
                    count = count + 2;
                }
                else if (message[i] == 'c' || message[i] == 'f' || message[i] == 'i' || message[i] == 'l' || message[i] == 'o' || message[i] == 'r' || message[i] == 'v' || message[i] == 'y')
                {
                    count = count + 3;
                }
                else if (message[i] == 's' || message[i] == 'z')
                {
                    count = count + 4;
                }


                if ((prev == 'a' || prev == 'b' || prev == 'c') && (message[i] == 'a' || message[i] == 'b' || message[i] == 'c') ||
                    (prev == 'd' || prev == 'e' || prev == 'f') && (message[i] == 'd' || message[i] == 'e' || message[i] == 'f') ||
                    (prev == 'g' || prev == 'h' || prev == 'i') && (message[i] == 'g' || message[i] == 'h' || message[i] == 'i') ||
                    (prev == 'j' || prev == 'k' || prev == 'l') && (message[i] == 'j' || message[i] == 'k' || message[i] == 'l') ||
                    (prev == 'm' || prev == 'n' || prev == 'o') && (message[i] == 'm' || message[i] == 'n' || message[i] == 'o') ||
                    (prev == 'p' || prev == 'q' || prev == 'r' || prev == 's') && (message[i] == 'p' || message[i] == 'q' || message[i] == 'r' || message[i] == 's') ||
                    (prev == 't' || prev == 'u' || prev == 'v') && (message[i] == 't' || message[i] == 'u' || message[i] == 'v') ||
                    (prev == 'w' || prev == 'x' || prev == 'y' || prev == 'z') && (message[i] == 'w' || message[i] == 'x' || message[i] == 'y' || message[i] == 'z')
                    )
                {
                    count = count + 2;
                }

                prev = message[i];
              
            }

            return count.ToString();
        }
    }
}
