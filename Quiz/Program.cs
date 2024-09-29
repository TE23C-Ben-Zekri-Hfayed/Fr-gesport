
int points = 0 ;

int failpoint = 0;

int revival = 0;

Console.WriteLine("Welcome to the Quiz show! You will answer some questions and if you get all the answers right you win a prize!!");

Console.WriteLine("Question 1.");
Console.WriteLine("");
Console.WriteLine("In the movie, 'Back to the Future', which car did they use to time travel?");
Console.WriteLine();
Console.WriteLine("a) DMC Delorean  b) Plymouth Fury  c) Chevrolet Corvette");

String answer1 = Console.ReadLine();

if (answer1 == "a")
{
    points++;
    Console.Clear();
    Console.WriteLine("And that's CORRECT!!");
    Console.ReadLine();
}
else
{
    failpoint++;
    Console.Clear();
    Console.WriteLine("Oof, that's incorrect, but don't worry! You randomly get a revival question in the end!");
    Console.ReadLine();
}
Console.Clear();
Console.WriteLine("Question 2!!");
Console.WriteLine("");
Console.WriteLine("In which year did the Titanic sink on its maiden voyage?");
Console.WriteLine();
Console.WriteLine("a) 1912  b) 1890  c) 1923");

String answer2 = Console.ReadLine();

if (answer2 == "a")
{
points++;
Console.Clear();
Console.WriteLine("That's also CORRECT!!");
Console.ReadLine();
}
else if (failpoint == 1)
{
    Console.Clear();
    Console.WriteLine("That's Incorrect! 2 mistakes already!");
    Console.ReadLine();
}
else
{
    failpoint++;
    Console.Clear();
    Console.WriteLine("That's incorrect!");
    Console.ReadLine();
}
Console.Clear();
Console.WriteLine("Question 3!!");
Console.WriteLine();
Console.WriteLine("What video-game company has own the game 'Minecraft' which is the most sold game in the world?");
Console.WriteLine();
Console.WriteLine("a) Landfalls  b) Valve  c) Microsoft");

String answer3 = Console.ReadLine();

if (answer3 == "c")
{
    points++;
    Console.Clear();
    Console.WriteLine("That's CORRECT!!");
    Console.ReadLine();
}
else
{
    failpoint++;
    Console.Clear();
    Console.WriteLine("That's incorrect!");
    Console.ReadLine();
}
 if (failpoint == 2)
{
    Console.Clear();
    Console.WriteLine("INCORRECT!!!");
    Console.WriteLine();
    Console.WriteLine("That's 3 questions answered wrong out of 4!");
}
Console.Clear();
Console.WriteLine("Question 4!");
Console.WriteLine();
Console.WriteLine("What is the chemical formula for table salt?");
Console.WriteLine();
Console.WriteLine("a) H20  b)  NaCI  c) CO2");
String answer4 = Console.ReadLine();
if (answer4 == "b" || answer4 == "B")
{
    points++;
Console.Clear();
Console.WriteLine("CORRECT!!");
Console.ReadLine();
}
else 
{
    failpoint++;
Console.Clear();
Console.WriteLine("");
Console.WriteLine("That's incorrect!!");
Console.ReadLine();
}
if (failpoint == 4)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("That's all the questions! Sadly you got all the questions wrong!");
    Console.WriteLine();
    Console.WriteLine("Do better next time!");
    Console.ReadLine();
}
if (failpoint == 3)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("That's all the questions! Sadly you got 3 wrong and 1 right!");
    Console.WriteLine();
    Console.WriteLine("Do better next time!");
Console.ReadLine();
}
if (failpoint == 2)
{
Console.Clear();
Console.WriteLine();
Console.WriteLine("That's all the questions! You got 2/4 questions right!");
Console.WriteLine();
Console.WriteLine("Sadly because you got more than 1 wrong, you don't qualify for a revival question!");
Console.ReadLine();
}
if (failpoint == 1)
{
    revival++;
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("That's all the questions! You got 3/4 questions right!");
    Console.WriteLine();
    Console.WriteLine("You qualify for a revival question! Here we go!");
    Console.ReadLine();
}
if (failpoint == 0)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Congratulations! You answered 4/4 questions right!");
    Console.WriteLine();
    Console.WriteLine("For your prize, you get $500,000");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("+ $500,000");
    Console.ResetColor(); 
    Console.ReadLine();
}
if (revival == 1)
{
 Console.Clear();
    Console.WriteLine("Revival Question!");
    Console.WriteLine();
    Console.WriteLine("Who killed the archduke of Austria?");
    Console.WriteLine();
    Console.WriteLine("a) Franz Ferdinand  b) Micheal jackson  c) Gavrilo Princip");
    String revivalanswer = Console.ReadLine();
    if (revivalanswer == "c" || revivalanswer == "C")
    {
        Console.Clear();
        Console.WriteLine("THAT'S CORRECT!! ");
        Console.WriteLine();
        Console.WriteLine("For your prize, you get $500,000");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("+ $500,000");
        Console.ResetColor(); 
        Console.WriteLine("Game Won!!");
        Console.ReadLine();
    }
    else 
    {
        Console.Clear();
        Console.WriteLine("That's INCORRECT!! Thank you for participating! Sadly, you lost!");
        Console.WriteLine();
        Console.WriteLine("Game over...");
        Console.ReadLine();
    }
}
   


