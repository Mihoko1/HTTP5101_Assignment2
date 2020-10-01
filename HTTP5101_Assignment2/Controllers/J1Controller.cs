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
