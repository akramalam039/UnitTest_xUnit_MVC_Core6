namespace UnitTest_xUnit_MVC_Core6
{
    public class Mathematics
    {
        public static bool IsEvenNumber(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public static bool IsOddNumber(int num)
        {
            return num % 2 == 1 ? true : false;
        }
        public static int SquareOfNumber(int num)
        {
            return num * num;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return (a - b);
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
