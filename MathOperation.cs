using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U3_4_metodos
{
    class MathOperation
    {
        // Attributes
        private double number1;
        private double number2;
        private double result;

        // Constructor
        public MathOperation(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        // Method to perform the mathematical operation
        public void PerformOperation()
        {
            result = number1 + number2;
        }

        // Read and write methods
        public void SetNumbers(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public double GetResult()
        {
            return result;
        }

        // Methods without reading and with writing
        public void SetResult(double res)
        {
            result = res;
        }

        // Methods with reading and without writing
        public double GetNumber1()
        {
            return number1;
        }

        public double GetNumber2()
        {
            return number2;
        }
    }
}
