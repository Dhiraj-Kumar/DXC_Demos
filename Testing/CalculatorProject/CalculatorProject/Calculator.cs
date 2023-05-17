namespace CalculatorProject
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                if (i % 2 != 0)
                {
                    yield return i;
                }
            }
        }
    }
}