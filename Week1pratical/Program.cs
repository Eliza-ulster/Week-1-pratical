
Age();



void Age()
{

    Console.WriteLine("Please enter your name :");
    String name = Console.ReadLine();
    Console.WriteLine("Please enter your age :");

    int age = Convert.ToInt32(Console.ReadLine());
    age += 5;


    Console.WriteLine("Hello " + name + " you will be " + age + " in 5 years ");

}
