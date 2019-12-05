using System;

public class Class1
{
	public Class1()
	{
     
    }
    void Start()
    {
        Console.WriteLine("Hi user. What is your name?");
        string nameOfUser = Console.ReadLine();
        Console.WriteLine("Hi " + nameOfUser);

        // task 5
        Console.WriteLine("Type in the first numer");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type in the second numer");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number selected are: " + number1 + "and " + number2);
        int tempBox = number1;
        number1 = number2;
        number2 = tempBox;


    }
}
