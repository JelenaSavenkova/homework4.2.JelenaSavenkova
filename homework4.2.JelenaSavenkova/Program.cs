using System;

namespace homework4JelenaSavenkova
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        Console.WriteLine("Hello user!\nWelcome to my program!");
        Console.WriteLine("Please choose one of the options below:");
        Console.WriteLine("Option 1 - Calculate circle area using radius");
        //Circle area A = πr²
        Console.WriteLine("Option 2 - Calculate square area using side lengh");
        //Square area = s * s
        Console.Write("Enter your choice now!: ");
        int option = Convert.ToInt32(Console.ReadLine());
        //not sure if how to avoid crashing when entered charachter
            #region areaCalc
            switch (option)
            {
            case 1:
                    Console.WriteLine("Circle area using radius");
                    Console.Write("Please enter radius: ");
                    double circleRadiusChoice = Convert.ToDouble(Console.ReadLine()); ;
                    const double π = 3.14159265359;
                    double circleArea = π * (circleRadiusChoice * circleRadiusChoice);
                    // A = πr²
                    Console.WriteLine($"Circle area with circle radius {circleRadiusChoice} is {circleArea}\n " +
                        $"Thank you for using this APP!");
            break;

            case 2:
                    Console.WriteLine("Square area using lengh");
                    Console.Write("Please enter side Lengh: ");
                    float squareLengh = float.Parse(Console.ReadLine());
                    float squareArea = squareLengh * squareLengh;
                    Console.WriteLine($"Area of square with side lengh {squareLengh} is {squareArea}.\n"+
                       $"Thank you for using this APP!");
                    Console.ReadLine();
            break;

            default:
                    Console.WriteLine("Invalid choice, try again!");
                    break;      
            }
            #endregion
        Console.ReadLine();
        }
    }
}
