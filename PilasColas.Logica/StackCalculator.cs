using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas.Logica
{
    public class StackCalculator
    {
        private Stack<double> stack = new Stack<double>();

        public void Push(double value)
        {
            stack.Push(value);
        }

        public void Add()
        {
            if (stack.Count >= 2)
            {
                double operand2 = stack.Pop();
                double operand1 = stack.Pop();
                double result = operand1 + operand2;
                stack.Push(result);
            }
            else
            {
                Console.WriteLine("No hay suficientes operandos en la pila para sumar.");
            }
        }

        public double GetResult()
        {
            if (stack.Count > 0)
            {
                return stack.Peek();
            }
            else
            {
                Console.WriteLine("Ningún resultado disponible.");
                return 0;
            }
        }
    }
}
