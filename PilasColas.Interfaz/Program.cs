using System;
using PilasColas.Logica;


try
{
    Console.WriteLine("=============> PILAS <=============");
    StackCalculator stackCalculator = new StackCalculator();
    stackCalculator.Push(5);
    stackCalculator.Push(3);
    stackCalculator.Add();
    Console.WriteLine("Resultado del calculo de pilas: " + stackCalculator.GetResult());

    Console.WriteLine("\n=============> COLAS <=============");
    QueueCalculator queueCalculator = new QueueCalculator();
    queueCalculator.Enqueue(8);
    queueCalculator.Enqueue(2);
    queueCalculator.Multiply();
    Console.WriteLine("Resultado del calculo de colas: " + queueCalculator.GetResult());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
