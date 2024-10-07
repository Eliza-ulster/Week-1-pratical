
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

Integers();
void Integers();
{
    Console.WriteLine("Please enter an interger");

    int Num = Convert.ToInt32(Console.ReadLine());
    if (Num ==0)
    {
        Console.WriteLine("This value equals 0");
    }
    else if(Num >0)
    {
        Console.WriteLine("This is a postive integer");
    }
    else if (Num <0)
    {
        Console.WriteLine("This a negative integer");
    }
}

LeapYear();
 

void LeapYear()
{
    Console.WriteLine("Enter a year");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year < 0)
    {
        Console.WriteLine($"{year} is not a vaild year. it must not be a negative number .");

    }
    else
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year");
        
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }

}
Numbers();

void Numbers()
{
    Console.WriteLine("Enter a number:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num %== 2)
    {
        Console.WriteLine("This ia an even number");

    }
    else
    {
        Console.WriteLine("This is an odd number");
    }
}