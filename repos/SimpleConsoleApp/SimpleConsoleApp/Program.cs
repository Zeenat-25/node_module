class ConsoleAPP {

    static void Main() {
        Console.WriteLine("Welcome To Simple Console Application ");
        Console.WriteLine("Enter Your Name : ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name);

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int square = number * number;

        Console.WriteLine("Square = " + square);

        Console.ReadKey();

    }
}