
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

UserAge();

void UserAge()
{
    Console.WriteLine("Please enter your age :");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 13)
    {
        Console.WriteLine(" You are a Child");
    }
    else if (age >= 13 && age <=19)
    {
        Console.WriteLine("You are a teenager");


    }
    else if (age <=110)
    {
        Console.WriteLine("You are old");
    }
    else
    {
        Console.WriteLine("You are entered a invaild age ")
    }
}