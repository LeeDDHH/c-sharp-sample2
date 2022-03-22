using System;

namespace Sample5_1_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力：");
            string s = Console.ReadLine();
            const string HELLO = "Hello";
            Boolean isEqualString = s.Equals(HELLO, StringComparison.OrdinalIgnoreCase);
            if (isEqualString) {
                Console.WriteLine("Helloが入力されました。");
            }
            else {
                Console.WriteLine("Helloと入力してください。");
            }
        }
    }
}
