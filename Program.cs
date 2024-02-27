using POO_U3_4_metodos;

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the MathOperation class
        MathOperation operation = new MathOperation(0, 0);

        // Use method without reading and with writing
        operation.SetResult(0);

        // Use method with reading and without writing
        double number1 = operation.GetNumber1();
        double number2 = operation.GetNumber2();

        // Use method with reading and writing
        operation.SetNumbers(8, 4);
        operation.PerformOperation();
        double result = operation.GetResult();

        // Use method without reading and without writing
        Console.WriteLine("The result of the operation is: " + result);
    }
}