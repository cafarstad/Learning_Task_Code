using System;

namespace ConsoleApp1_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // find Task at this link
            // https://www.w3resource.com/csharp-exercises/basic/index.php#editorr
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi user. What is your name?");
            string nameOfUser = Console.ReadLine();
            Console.WriteLine("Hi " + nameOfUser); */
            bool exit = false;
            while(exit == false)
            {
                Console.WriteLine("Witch Task-NUMBER do you want to see?");
                Console.WriteLine("Task available are: 5 \t 6 \t 8");
                //Console.WriteLine("To quite, type exit");
                int taskSelected = Convert.ToInt32(Console.ReadLine());
                switch (taskSelected)
                {
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 8:
                        Task8();
                        break;



                }
            }
           
          





        }
        static void Task5()
        {
            // task 5
            Console.WriteLine("This is Task 5");
            Console.WriteLine("Type in the first numer");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the second numer");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number selected are:\n" + number1 + " and " + number2);
            int tempBox = number1;
            number1 = number2;
            number2 = tempBox;
            Console.WriteLine("new order is: " + number1 + " and " + number2);

        }
        static void Task6()
        {
            Console.WriteLine("We gonna multiply 3-numbers");
            Console.WriteLine("Type in the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the Third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2 + num3;
            Console.WriteLine(num1 +"x"+ num2+"x" + num3 +"="+sum);

        }
        static void Task8()
        {
            Console.WriteLine("type a number you want to se be multiplied from 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(count <= 10)
            {
                int total = (number * count);
                Console.WriteLine(number + "x" + count + "=" + total);
                count++;
            }
            
        }
        static void Task9()
        {


        }
    }

}
