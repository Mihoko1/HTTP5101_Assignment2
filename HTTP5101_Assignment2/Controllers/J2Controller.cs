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
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {

            int sum = 0;
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
