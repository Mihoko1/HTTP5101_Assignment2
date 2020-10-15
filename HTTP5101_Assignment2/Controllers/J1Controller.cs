using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// Receives input of the integer representing the index burger, drink, side, and dessert choice and provides a message how much calories in total.
        /// </summary>
        /// <param name="burger">Integer representing the index burger choise</param>
        /// <param name="drink">Integer representing the index drink choise</param>
        /// <param name="side">Integer representing the index side choise</param>
        /// <param name="dessert">Integer representing the index dessert choise></param>
        /// <example>GET api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"</example>
        /// <example>GET api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"</example>
        /// <returns>The total calories of the meal</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            int[] burgerCal = { 461, 431, 420, 0 };
            int[] drinkCal = { 130, 160, 118, 0 };
            int[] sideCal = { 100, 57, 70, 0 };
            int[] dessertCal = { 167, 266, 75, 0 };

            int burgerIndex = burger - 1;
            int drinkIndex = drink - 1;
            int sideIndex = side - 1;
            int desserIndex = dessert - 1;

            int totalCal = burgerCal[burgerIndex] + drinkCal[drinkIndex] + sideCal[sideIndex] + dessertCal[desserIndex];
            return "Your total calorie count is " + totalCal;
        }
    }
}
