namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            try
            {
                Console.WriteLine("Enter First Number");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                b = Convert.ToInt16(Console.ReadLine());
                if (a < b)
                {
                    throw new IncorrectValueException("Value of first number cannot be less than second number");
                }
                c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide any number by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (IncorrectValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine($"The result is {c}");
                Console.WriteLine("Program End.");
            }
        }
    }
}