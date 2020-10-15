using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        ///  Receives input of the integer representing how many sides first and second dice have and provides a message how many ways to get the sum 10.
        /// </summary>
        /// <param name="m">Positive integer representing the number of sides on the first die</param>
        /// <param name="n">Positive integer representing the number of sides on the second die</param>
        /// <example> Get api/J2/DiceGame/6/8 -> "There are 5 ways to get the sum 10" </example>
        /// <example> Get api/J2/DiceGame/12/4 -> "There are 4 ways to get the sum 10" </example>
        /// <example> Get api/J2/DiceGame/3/3 -> "There are 0 ways to get the sum 10" </example>
        /// <example> Get api/J2/DiceGame/5/5 -> "There is 1 way to get the sum 10" </example>
        /// <returns>How many ways to get the sum 10</returns>


        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {

            int sum;
            int total = 0;
            string message;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    sum = i + j;

                    if (sum == 10)
                    {
                        total++;
                    }
                }
            }

            if (total == 1)
            {
               message = "There is " + total + " way to get the sum 10";
            }
            else
            {
                message = "There are " + total + " ways to get the sum 10";
            }
            return message; 
        }
    }
}
