namespace OOP_Principles_3
{
    internal class Program
    {
        private static string binary;

        private static string octal;

        private static string hexa;


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number!");
            var IsNum = int.TryParse(Console.ReadLine(), out int num);
            if (IsNum==false)
            {
                throw new Exception("Sorry! Try again!");
            }
            DecimalNumbers.BinarySystem(num,binary);
            Console.WriteLine("\b");
            DecimalNumbers.OctalSystem(num,octal);
            Console.WriteLine("\b");
            DecimalNumbers.HexadecimalSystem(num, hexa);
        }
    }
}