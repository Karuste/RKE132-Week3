

Console.WriteLine("Enter a number:");

int userNum = Convert.ToInt32(Console.ReadLine());

//kas arv on paaris või paaritu

int result = userNum % 2;


Console.WriteLine(result);
if (result != 0) // != - ei ole võrdne
{
    Console.WriteLine("Your number is odd.");
}
else
{
    Console.WriteLine("Your number is even.");
}

