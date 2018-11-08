using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using inclass_4.Models;

using MathLibrary;

namespace inclass_4.Controllers
{
    public class ConverterController : Controller
    {
        public string Add(decimal left, decimal right)
        {
            MyMath routines = new MyMath();
            decimal value = routines.Add(left, right);
            return $"{left} plus {right} is: {value}";
        }

        public string Ceiling(decimal number)
        {
            MyMath routines = new MyMath();
            decimal result = routines.Ceiling(number);
            return $"The ceiling of {number} is {result}";
            
        }

        public string Subtract(decimal left, decimal right)
        {
            MyMath routines = new MyMath();
            decimal value = routines.Subtract(left, right);
            return $"{left} minus {right} is: {value}";
        }

        public string Multiply(decimal left, decimal right)
        {
            MyMath routines = new MyMath();
            decimal value = routines.Multiply(left, right);
            return $"{left} multiplied by {right} is: {value}";
        }

        public string Divide(decimal left, decimal right)
        {
            MyMath routines = new MyMath();
            decimal value = routines.Divide(left, right);
            return $"{left} divided by {right} is: {value}";
        }

        public string Floor(decimal number)
        {
            MyMath routines = new MyMath();
            decimal result = routines.Floor(number);
            return $"The ceiling of {number} is {result}";
        }

        public string Power(double number, double power)
        {
            MyMath routines = new MyMath();
            double results = routines.Power(number, power);
            return $"{number} to the power of {power} is: {results}";
        }

     
    }
}
