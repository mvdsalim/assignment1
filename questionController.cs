using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Madeleine.Controllers
{
    [RoutePrefix("api")]
    public class questionController : ApiController
    {
        /// <summary>
        /// This method adds 10 integer to the input
        /// for example - if the input is 1 then output is 11
        /// </summary>
        /// <param name="number">Represents integer number in which 10 integer is to be added</param>
        /// <returns>return integer after adding 10</returns>
        [HttpGet]
        [Route("AddTen/{number}")]
        public int AddTen(int number)
        {
            return (number + 10);
        }

        /// <summary>
        /// This method return square root of the input number
        /// for example - if input is 3 then result will be 9
        /// </summary>
        /// <param name="number">represents integer whose square root is to calculated</param>
        /// <returns>Integer number</returns>
        [HttpGet]
        [Route("Square/{number}")]
        public int Square(int number)
        {
            return (number * number);
        }

        /// <summary>
        /// This method is called via HttpPost verb and it return string
        /// </summary>
        /// <returns>It returns Hello World! string</returns>
        [HttpPost]
        [Route("Greeting")]
        public string Greeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method creates string as per input number
        /// for example if input is 10 then it returns
        /// Greetings to 10 people!
        /// </summary>
        /// <param name="id">Represents integer number</param>
        /// <returns>Return string as per input number</returns>
        [HttpGet]
        [Route("Greeting/{id}")]
        public string Greeting(int id)
        {
            return "Greetings to " + id.ToString() + " people!";
        }

        /// <summary>
        /// This method do 4 mathematical operations on the input number
        /// for example - if the input is 1 then the output is 19
        /// it performs number+1 then result *10 then result -1 then result / 1
        /// </summary>
        /// <param name="id">Any integer number</param>
        /// <returns>result integer after performing 4 mathematical operations</returns>
        [HttpGet]
        [Route("NumberMachine/{id}")]
        public int NumberMachine(int id)
        {
            id = id + 1;
            id = id * 10;
            id = id - 1;
            id = id / 1;
            return id;
        }

        /// <summary>
        /// This method calculates count, price, hst and total and returns 3 strings by getting input as a number(number of days which has elapsed since the beginning of the hosting)
        /// for example if the input is 14 then 3 strings are
        /// 2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD
        /// </summary>
        /// <param name="id">Represents the number of days which has elapsed since the beginning of the hosting</param>
        /// <returns>3 strings which describes the total hosting cost</returns>
        [HttpGet]
        [Route("HostingCost/{id}")]
        public string[] HostingCost(int id)
        {
            int count = ((id / 14) + 1);
            double price = (count * 5.50);
            double hst = ((0.13) * price);
            double total = hst + price;
            string[] returnvalue = new string[3];
            returnvalue[0] = count.ToString() + " fortnights at $5.50/FN = $" + price.ToString("F") + " CAD";
            returnvalue[1] = "HST 13% = $" + hst.ToString("F") + " CAD";
            returnvalue[2] = "Total = $" + total.ToString("F") + " CAD";
            return returnvalue;
        }
    }
}
