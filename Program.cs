// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace MultiplicationApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int number =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiplication table of number "+number+" is: ");
            if (number>0 && number <= 100)
            {
                for (int i= 1; i <= 10; i++)
                {
                    Console.WriteLine(number +"*"+ i +"="+ number*i);
                };
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
