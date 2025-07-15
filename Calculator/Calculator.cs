using System.Text;

namespace Calculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор: ");
            string op = Console.ReadLine();

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());


            double result = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => b != 0 ? a / b : throw new DivideByZeroException("Делить на ноль нельзя"),
                _ => throw new InvalidOperationException("Неизвестный оператор")
            };

            Console.WriteLine($"Result : {(decimal)result}");
        }
    }
}


