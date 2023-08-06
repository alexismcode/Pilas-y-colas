using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas.Logica
{
    public class QueueCalculator
    {
        private Queue<double> queue = new Queue<double>();

        public void Enqueue(double value)
        {
            queue.Enqueue(value);
        }

        public void Multiply()
        {
            if (queue.Count >= 2)
            {
                double operand1 = queue.Dequeue();
                double operand2 = queue.Dequeue();
                double result = operand1 * operand2;
                queue.Enqueue(result);
            }
            else
            {
                Console.WriteLine("No hay suficientes operandos en la cola para la multiplicación.");
            }
        }

        public double GetResult()
        {
            if (queue.Count > 0)
            {
                return queue.Peek();
            }
            else
            {
                Console.WriteLine("Ningún resultado disponible.");
                return 0;
            }
        }
    }
}
